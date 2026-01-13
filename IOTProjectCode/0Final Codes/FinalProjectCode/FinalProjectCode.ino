//const int s0 = 8; 
//const int s1 = 9; 
#include <Servo.h>

//Servo myServo1;
//Servo myServo2;
const int ir_sensor1 = 2;
const int buzzer = 3;
const int s2 = 12; 
const int s3 = 11; 
const int out = 10;
const int relay = 13;
//const int ir_sensor2 = 4;



// Product counters
int redCount = 0;
int greenCount = 0;
int blueCount = 0;
int totalProductCount = 0;
int defectiveProductCount = 0;

// Variables 
int red = 0; 
int green = 0; 
int blue = 0;
//String x ="";
   
void setup()  
{ 
  Serial.begin(9600);
  //pinMode(s0, OUTPUT); 
  //pinMode(s1, OUTPUT); 
  pinMode(ir_sensor1, INPUT);
  pinMode(relay, OUTPUT);
  digitalWrite(relay, HIGH); // Conveyor off initially
  pinMode(buzzer, OUTPUT);

  pinMode(s2, OUTPUT); 
  pinMode(s3, OUTPUT); 
  pinMode(out, INPUT);
/*
  myServo1.attach(5); //turnaround motor
  myServo2.attach(6); //catcher
  myServo1.write(0);
  //delay(1000); 
*/
} 
   
void loop()
{ 
   // Process serial input for setting dimensions and controlling conveyor
    if (Serial.available()) {
        String command = Serial.readStringUntil('\n');
        
        if (command == "START") {
            digitalWrite(relay, LOW); // Start conveyor
            Serial.println("Conveyor Started");
        } else if (command == "STOP") {
            digitalWrite(relay, HIGH); // Stop conveyor
            Serial.println("Conveyor Stopped");
        } else if (command == "RESET") { //get resetbutton signal
            resetCounters();
        }
    }


  color();

  if (digitalRead(ir_sensor1) == LOW){
    delay(25);
    digitalWrite(buzzer, HIGH); // Sound buzzer
    digitalWrite(relay, HIGH);  // Stop conveyor
    delay(300);
    //digitalWrite(buzzer, HIGH);
    digitalWrite(buzzer, LOW);  // Turn off buzzer
    
    
    if ((red > blue && red > green) && (red > 100 && red < 280) && (green > 10 && green < 110) && (blue > 10 && blue < 110))
    { 
      Serial.println(" Red Color");
      //x += " Red Color";
      redCount++;
      totalProductCount++;
    }
    else if ((blue > red) && (blue < 250 && blue > 130) && (green > 120 && green < 250) && (red > 40 && red < 150))
    { 
      Serial.println(" Blue Color"); 
      //x += " Blue Color";
      blueCount++;
      totalProductCount++;
    }
    else if ((green > blue) && (green > 170 && green < 300) && (blue > 110 && blue < 220) && (red > 170 && red < 300))
    { 
      Serial.println(" Green Color"); 
      //x += " Green Color";
      greenCount++;
      totalProductCount++;
    }
    else
    {
      Serial.println(" Defective Product");
      //x += " Defective Product";
      defectiveProductCount++;
    }
    delay(1000);
    digitalWrite(relay, LOW);//start conveyor
    delay(50);
    //digitalWrite(ir_sensor, HIGH); 
     
    
  }
  
    // Send data to C# application
  
    Serial.println("Red Count:" + String(redCount));
    Serial.println("Blue Count:" + String(blueCount));
    Serial.println("Green Count:" + String(greenCount));
    Serial.println("Total Count:" + String(totalProductCount));
    Serial.println("Defective Count:" + String(defectiveProductCount));

    
   //digitalWrite(relay, LOW); // start conveyor
   // digitalWrite(ir_sensor, HIGH);
/*
  if (digitalRead(ir_sensor2) == LOW){

    delay(110);
    digitalWrite(buzzer, HIGH);
    digitalWrite(relay, HIGH); 
    delay(300);
    digitalWrite(buzzer, LOW);

    if ( x == " Red Color")
    {
      //Red colour
      catcher ();

      for ( int i = 0; i<=45; i++){
        myServo1.write(i); 
        delay(10);
      }
      delay(1000);
      catcher ();
      delay(1000);

      for (int j =45; j >=0; j--){
        myServo1.write(j);
        delay(10);
      }
      delay(1000);
    }
    else if (x == " Blue Color")
    {
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
    }
    else if (x == " Green Color")
    {
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
    }
    else if (x == " Defective Product")
    {
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
    delay(1000);
  }*/
}
/*
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
*/
//reset counts 
void resetCounters() {
  redCount = 0;
  greenCount = 0;
  blueCount = 0;
  totalProductCount = 0;
  defectiveProductCount = 0;
  Serial.println("Counters reset");
}

void color() 
{   
  digitalWrite(s2, LOW); 
  digitalWrite(s3, LOW); 
  //count OUT, pRed, RED 
  red = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 
  digitalWrite(s3, HIGH); 
  //count OUT, pBLUE, BLUE 
  blue = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 
  digitalWrite(s2, HIGH);
  //count OUT, pGreen, GREEN 
  green = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 

  red = map(red,232,93,0,255);
  green = map(green,249,98,0,255);
  blue = map(blue,235,86,0,255);
}