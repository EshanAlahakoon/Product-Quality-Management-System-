#include <Servo.h>  // Include Servo library

Servo servo1;  // Define Servo 1 for the base
Servo servo2;  // Define Servo 2 for the arm joint

// Define the pins for the servos
const int servo1Pin = 9; // catcher
const int servo2Pin = 10;

void setup() {
  // Attach the servos to the defined pins
  servo1.attach(servo1Pin);
  servo2.attach(servo2Pin);
  
  Serial.begin(9600); // Start Serial Monitor
}

void loop() {
  // Move each servo from 0 to 180 degrees
  for (int pos = 40; pos <= 75; pos += 30) {
    servo1.write(pos);  // Move base
    servo2.write(pos);  // Move arm joint
    delay(5000);         // Wait for servo to reach position
    Serial.print("Servo1 Position: "); Serial.print(pos);
    Serial.print(", Servo2 Position: "); Serial.println(pos);
  }
  
  // Move each servo from 180 to 0 degrees
  for (int pos = 75; pos >= 40; pos -= 30) {
    servo1.write(pos);
    servo2.write(pos);
    delay(500);
    Serial.print("Servo1 Position: "); Serial.print(pos);
    Serial.print(", Servo2 Position: "); Serial.println(pos);
  }
}
