#include <Servo.h>


// Define pins for sensors and relay/motor control
const int IR_SENSOR_PIN = 2;
const int RELAY_PIN = 8; // For controlling conveyor motor relay
const int COLOR_SENSOR_S2 = 4;
const int COLOR_SENSOR_S3 = 5;
const int COLOR_SENSOR_OUT = 6;
const int TRIG_PIN_LENGTH = 7;  // Ultrasonic for length
const int ECHO_PIN_LENGTH = 8;
const int TRIG_PIN_WIDTH = 9;   // Ultrasonic for width
const int ECHO_PIN_WIDTH = 10;
const int TRIG_PIN_HEIGHT = 11; // Ultrasonic for height
const int ECHO_PIN_HEIGHT = 12;

// Product counters
int redCount = 0;
int yellowCount = 0;
int blueCount = 0;
int goodProductCount = 0;
int colorDefectiveCount = 0;
int dimensionsDefectiveCount = 0;


void setup() {
    Serial.begin(9600);
    pinMode(IR_SENSOR_PIN, INPUT);
    pinMode(RELAY_PIN, OUTPUT);
    digitalWrite(RELAY_PIN, LOW);
    pinMode(COLOR_SENSOR_S2, OUTPUT);
    pinMode(COLOR_SENSOR_S3, OUTPUT);
    pinMode(COLOR_SENSOR_OUT, INPUT);
    pinMode(TRIG_PIN_LENGTH, OUTPUT);
    pinMode(ECHO_PIN_LENGTH, INPUT);
    pinMode(TRIG_PIN_WIDTH, OUTPUT);
    pinMode(ECHO_PIN_WIDTH, INPUT);
    pinMode(TRIG_PIN_HEIGHT, OUTPUT);
    pinMode(ECHO_PIN_HEIGHT, INPUT);
    
}

// Utility to read ultrasonic distance
long readUltrasonicDistance(int trigPin, int echoPin) {
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
    long duration = pulseIn(echoPin, HIGH);
    return duration * 0.034 / 2; // Convert to centimeters
}

// Utility to read color
String readColor() {
    // Simplified color detection logic
    digitalWrite(COLOR_SENSOR_S2, LOW);
    digitalWrite(COLOR_SENSOR_S3, LOW);
    int red = pulseIn(COLOR_SENSOR_OUT, LOW);

    digitalWrite(COLOR_SENSOR_S2, HIGH);
    digitalWrite(COLOR_SENSOR_S3, HIGH);
    int blue = pulseIn(COLOR_SENSOR_OUT, LOW);

    digitalWrite(COLOR_SENSOR_S2, LOW);
    digitalWrite(COLOR_SENSOR_S3, HIGH);
    int green = pulseIn(COLOR_SENSOR_OUT, LOW);

    if (red < blue && red < green) return "Red";
    else if (blue < red && blue < green) return "Blue";
    else return "Yellow";
}


void loop() {
   // Check for IR sensor trigger to stop conveyor and scan product
    if (digitalRead(IR_SENSOR_PIN) == HIGH) {
        digitalWrite(RELAY_PIN, LOW); // Stop conveyor
        delay(500);

    // Measure product dimensions
        long length = readUltrasonicDistance(TRIG_PIN_LENGTH, ECHO_PIN_LENGTH);
        long width = readUltrasonicDistance(TRIG_PIN_WIDTH, ECHO_PIN_WIDTH);
        long height = readUltrasonicDistance(TRIG_PIN_HEIGHT, ECHO_PIN_HEIGHT);  


        // Read color
        String color = readColor();

        // Validate and classify product
        if (color == "Red" || color == "Blue" || color == "Yellow") {
            if (color == "Red") redCount++;
            else if (color == "Blue") blueCount++;
            else yellowCount++;
            goodProductCount++;
            Serial.println("Good Product Detected: " + color);
        } else {
            colorDefectiveCount++;
            Serial.println("Color Defective Product");
        }

        if (length < 10 || width < 10 || height < 10) {
            dimensionsDefectiveCount++;
            Serial.println("Dimension Defective Product");
        }


        // Send data to Visual Studio GUI
        Serial.println("Red Count:" + String(redCount));
        Serial.println("Blue Count:" + String(blueCount));
        Serial.println("Yellow Count:" + String(yellowCount));
        Serial.println("Good Count:" + String(goodProductCount));
        Serial.println("Color Defects:" + String(colorDefectiveCount));
        Serial.println("Dimension Defects:" + String(dimensionsDefectiveCount));

        delay(1000);
        digitalWrite(RELAY_PIN, HIGH); // Resume conveyor
    }
        //conveyor start stop display output

    if (Serial.available() > 0) {
        String command = Serial.readStringUntil('\n');
        if (command == "START") {
            digitalWrite(RELAY_PIN, HIGH); // Start conveyor
            Serial.println("Conveyor Started");
        } else if (command == "STOP") {
            digitalWrite(RELAY_PIN, LOW); // Stop conveyor
            Serial.println("Conveyor Stopped");
        }  else if (command.startsWith("SET_DIMENSIONS")) {
            // Parse dimensions if needed
            Serial.println("Dimensions Set");
        }
    }
}
