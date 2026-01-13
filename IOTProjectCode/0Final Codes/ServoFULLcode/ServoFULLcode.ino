#include <Servo.h>

Servo myServo1;
Servo myServo2;

void setup() {
  myServo1.attach(5);    // Attach the servo1 to pin 9     //turnaround motor
  myServo2.attach(6);   // Attach the servo2 to pin 10    // catcher
  myServo1.write(0);    // Start at a neutral position (stop)
  delay(1000);

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
  catcher ();

  for ( int i = 0; i<=50; i++){
    myServo1.write(i); 
    delay(10);
  }
  delay(1000);
  catcher ();
  delay(1000);

  for (int j =50; j >=0; j--){
    myServo1.write(j);
    delay(10);
  }
  delay(1000);

//Blue colour
  catcher ();

  for (int i = 0; i<=90; i++){
    myServo1.write(i); 
    delay(10);
  }
  delay(1000);
  catcher ();
  delay(1000);

  for (int j =90; j >=0; j--){
    myServo1.write(j);
    delay(10);
  }
  delay(1000);

//Green colour
  catcher ();

  for (int i = 0; i<=135; i++){
    myServo1.write(i); 
    delay(10);
  }
  delay(1000);
  catcher ();
  delay(1000);

  for (int j =135; j >=0; j--){
    myServo1.write(j);
    delay(10);
  }
  delay(1000);

//Defective Product
  catcher ();

  for (int i = 0; i<=180; i++){
    myServo1.write(i); 
    delay(10);
  }
  delay(1000);
  catcher ();
  delay(1000);

  for (int j =180; j >=0; j--){
    myServo1.write(j);
    delay(10);
  }
  delay(1000);
}


//catcher code
void catcher (){

  //open catcher
  for ( int i = 30; i<=55; i++){
    myServo2.write(i); 
    delay(5);
  }
  //myServo.write(45);
  delay(1000);
  for (int j =55; j >=30; j--){
    myServo2.write(j);
    delay(5);
    
  }
  delay(1000);

}

