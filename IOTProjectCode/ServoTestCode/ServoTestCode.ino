#include <Servo.h>

Servo myServo;

void setup() {
  myServo.attach(9);    // Attach the servo to pin 9
  myServo.write(0);    // Start at a neutral position (stop)
  delay(1000);          // Wait to stabilize
}

void loop() {

/*
   for ( int i = 0; i<=180; i++){
    myServo.write(i); 
    delay(15);
  }
  //myServo.write(45);
  delay(1000);
  for (int j = 180; j >=0; j--){
    myServo.write(j);
    delay(15);
  }
  delay(1000);
  */



//Red colour
  for ( int i = 0; i<=45; i++){
    myServo.write(i); 
    delay(10);
  }
  //myServo.write(45);
  delay(1000);
  for (int j =45; j >=0; j--){
    myServo.write(j);
    delay(10);
  }
  delay(2000);

//Blue colour
  for (int i = 0; i<=90; i++){
    myServo.write(i); 
    delay(10);
  }
  delay(1000);
  for (int j =90; j >=0; j--){
    myServo.write(j);
    delay(10);
  }
  delay(2000);

//Green colour
  for (int i = 0; i<=135; i++){
    myServo.write(i); 
    delay(10);
  }
  delay(1000);
  for (int j =135; j >=0; j--){
    myServo.write(j);
    delay(10);
  }
  delay(2000);

//Defective Product
  for (int i = 0; i<=180; i++){
    myServo.write(i); 
    delay(10);
  }
  delay(1000);
  for (int j =180; j >=0; j--){
    myServo.write(j);
    delay(10);
  }
  delay(2000);
}

