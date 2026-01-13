const int s2 = 12; 
const int s3 = 11; 
const int out = 10;

int red = 0; 
int green = 0; 
int blue = 0; 

void setup() { 
  Serial.begin(9600);
  pinMode(s2, OUTPUT); 
  pinMode(s3, OUTPUT); 
  pinMode(out, INPUT); 
}

void loop() {
  measureColor();

  Serial.print("Mapped R: "); 
  Serial.print(red); 
  Serial.print(" Mapped G: "); 
  Serial.print(green); 
  Serial.print(" Mapped B: "); 
  Serial.println(blue); 

  delay(1000); // Adjust delay if needed
}

void measureColor() {   
  digitalWrite(s2, LOW); 
  digitalWrite(s3, LOW); 
  red = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 

  digitalWrite(s3, HIGH); 
  blue = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 

  digitalWrite(s2, HIGH);
  green = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 

  // Apply mapping function to normalize values
  red = map(red, 218, 86, 0, 255);
  green = map(green, 236, 82, 0, 255);
  blue = map(blue, 223, 73, 0, 255);
}
