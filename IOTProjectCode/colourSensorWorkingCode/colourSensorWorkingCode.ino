//const int s0 = 8; 
//const int s1 = 9; 
const int s2 = 12; 
const int s3 = 11; 
const int out = 10;

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
   
void setup()  
{ 
  Serial.begin(9600);
  //pinMode(s0, OUTPUT); 
  //pinMode(s1, OUTPUT); 
  pinMode(s2, OUTPUT); 
  pinMode(s3, OUTPUT); 
  pinMode(out, INPUT); 

  /*pinMode(redLed, OUTPUT); 
  pinMode(greenLed, OUTPUT); 
  pinMode(blueLed, OUTPUT); */

  //digitalWrite(s0, HIGH); 
  //digitalWrite(s1, HIGH); 
} 
   
void loop()
{ 
  color();
  /*
  Serial.print("\n R Intensity:"); 
  Serial.print(red, DEC); 
  Serial.print(" G Intensity: "); 
  Serial.print(green, DEC); 
  Serial.print(" B Intensity : "); 
  Serial.print(blue, DEC); 
  */
  //Serial.println(); 

  if ((red > blue && red > green) && (red >100 && red < 280) && (green > 0 && green < 110) && (blue > 0 && blue < 110))
  { 
   Serial.println(" Red Color"); 
   redCount++;
   totalProductCount++;
  } 

  else if ((blue > red) && (blue < 250 && blue > 100) && (green > 90 && green < 250) && (red > 0 && red < 150))
  { 
   Serial.println(" Blue Color"); 
   blueCount++;
   totalProductCount++;
  } 

  else if ((green > blue) && (green > 90 && green < 300) && (blue > 10 && blue < 290) && (red > 80 && red < 320))
  { 
   Serial.println(" Green Color"); 
   greenCount++;
   totalProductCount++;
  } 
  else
  {
  Serial.println(" Defective Product");
  defectiveProductCount++;
  }
  delay(2000);
  
  // Send data to C# application
  
  Serial.println("Red Count:" + String(redCount));
  Serial.println("Blue Count:" + String(blueCount));
  Serial.println("Green Count:" + String(greenCount));
  Serial.println("Total Count:" + String(totalProductCount));
  Serial.println("Defective Count:" + String(defectiveProductCount));


  //get resetbutton signal 
  if (Serial.available()) {
    String command = Serial.readStringUntil('\n');
    command.trim();
    if (command == "RESET") {
      resetCounters();
    }
  }

} 

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

  red = map(red,251,100,0,255);
  green = map(green,271,106,0,255);
  blue = map(blue,254,92,0,255);
}
