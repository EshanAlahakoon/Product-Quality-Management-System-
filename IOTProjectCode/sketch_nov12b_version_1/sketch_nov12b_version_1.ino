#include <Servo.h>

Servo myServo;

void setup() {
  myServo.attach(9);  // Attach the servo to pin 9
}

void loop() {
  myServo.write(0);   // Rotate clockwise
  delay(200);         // Wait for 2 seconds
  
  myServo.write(180); // Rotate counterclockwise
  delay(200);         // Wait for 2 seconds
  
  myServo.write(180);  // Stop the motor
  delay(200);         // Wait for 2 seconds
}
