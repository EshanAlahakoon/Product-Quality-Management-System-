#include <Servo.h>

Servo myServo;

void setup() {
  myServo.attach(9);    // Attach the servo to pin 9
  myServo.write(90);    // Start at a neutral position (stop)
  delay(1000);          // Wait to stabilize
}

void loop() {
  // Rotate forward for a short time to simulate moving to a specific angle
  myServo.write(50);     // Full speed in one direction
  delay(300);           // Adjust this value to simulate turning to 90 degrees
  myServo.write(90);    // Stop the servo
  delay(2000);          // Hold position for 2 seconds

  // Rotate backward to return to the starting point
  myServo.write(80);   // Full speed in the opposite direction
  delay(311);           // Adjust this value to simulate the return to the start
  myServo.write(90);    // Stop the servo
  delay(2000);          // Hold position for 2 seconds
}
