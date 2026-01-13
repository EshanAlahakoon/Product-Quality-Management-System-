#include <Servo.h>

Servo myServo;

void setup() {
  myServo.attach(6);    // Attach the servo to pin 9
  //myServo.write(90);    // Start at a neutral position (stop)
  //delay(1000);          // Wait to stabilize
}

void loop() {
  
  //open catcher
  for ( int i = 30; i<=55; i++){
    myServo.write(i); 
    delay(20);
  }
  //myServo.write(45);
  delay(1000);
  for (int j =55; j >=30; j--){
    myServo.write(j);
    delay(2);
    
  }
  delay(2000);
}
