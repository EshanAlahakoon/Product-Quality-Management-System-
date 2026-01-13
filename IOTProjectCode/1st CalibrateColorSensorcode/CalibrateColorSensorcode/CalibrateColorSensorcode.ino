//#define S0 8
//#define S1 9
#define S2 12
#define S3 11
#define sensorOut 10

void setup() {
  //pinMode(S0, OUTPUT);
  //pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);
  pinMode(sensorOut, INPUT);
  //digitalWrite(S0, HIGH);
  //digitalWrite(S1, LOW);
  Serial.begin(9600);
}

void loop() {
  // Red
  digitalWrite(S2, LOW);
  digitalWrite(S3, LOW);
  int redFrequency = pulseIn(sensorOut, LOW);
  Serial.print("Red Frequency: ");
  Serial.println(redFrequency);

  // Green
  digitalWrite(S2, HIGH);
  digitalWrite(S3, HIGH);
  int greenFrequency = pulseIn(sensorOut, LOW);
  Serial.print("Green Frequency: ");
  Serial.println(greenFrequency);

  // Blue
  digitalWrite(S2, LOW);
  digitalWrite(S3, HIGH);
  int blueFrequency = pulseIn(sensorOut, LOW);
  Serial.print("Blue Frequency: ");
  Serial.println(blueFrequency);

  delay(1000);
}
