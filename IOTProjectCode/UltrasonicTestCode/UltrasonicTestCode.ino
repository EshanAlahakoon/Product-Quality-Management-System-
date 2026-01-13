const int TRIG_PIN_HEIGHT = 9; // Ultrasonic sensor TRIG pin
const int ECHO_PIN_HEIGHT = 8; // Ultrasonic sensor ECHO pin
float targetHeight = 0.0;       // User-defined target height
bool dimensionsReceived = false;
int dimensionDefectCount = 0;   // Count for defective products due to wrong dimensions

void setup() {
  Serial.begin(9600); // Start serial communication at 9600 baud rate
  pinMode(TRIG_PIN_HEIGHT, OUTPUT);
  pinMode(ECHO_PIN_HEIGHT, INPUT);
  Serial.println("Arduino Ready");
}

long readUltrasonicDistance(int trigPin, int echoPin) {
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  long duration = pulseIn(echoPin, HIGH);
  return duration * 0.034 / 2; // Convert time to centimeters
}

void loop() {
  if (Serial.available()) {
    String command = Serial.readStringUntil('\n');
    if (command.startsWith("SET_DIMENSIONS")) {
      sscanf(command.c_str(), "SET_DIMENSIONS,%f", &targetHeight);
      dimensionsReceived = true;
      Serial.print("Target Height Set: ");
      Serial.println(targetHeight);
    }
  }

  if (dimensionsReceived) {
    long measuredHeight = readUltrasonicDistance(TRIG_PIN_HEIGHT, ECHO_PIN_HEIGHT);

    Serial.print("Measured Height: ");
    Serial.print(measuredHeight);
    Serial.println(" cm");

    // Check if the measured height matches the target height (±1 cm tolerance)
    if (abs(measuredHeight - targetHeight) <= 1.0) {
      Serial.println("✔ STATUS: OK");
    } else {
      Serial.println("✖ STATUS: MISMATCH");
      dimensionDefectCount++; // Increase defect count
      Serial.print("Dimension Defective Count: ");
      Serial.println(dimensionDefectCount);
    }

    delay(2000); // Wait before the next measurement
  }
}
