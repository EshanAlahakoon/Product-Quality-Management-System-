#include <Servo.h>

Servo myServo1;
Servo myServo2;
const int ir_sensor1 = 2;
const int buzzer = 3;
const int s2 = 12; 
const int s3 = 11; 
const int out = 10;
const int relay = 13;
const int ir_sensor2 = 4;

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
String x = "";

void setup() { 
  Serial.begin(9600);
  
  pinMode(ir_sensor1, INPUT);
  pinMode(relay, OUTPUT);
  digitalWrite(relay, HIGH); // Conveyor off initially
  pinMode(buzzer, OUTPUT);

  pinMode(s2, OUTPUT); 
  pinMode(s3, OUTPUT); 
  pinMode(out, INPUT);

  myServo1.attach(5); // Turnaround motor
  myServo2.attach(6); // Catcher

  myServo1.write(0);
  myServo2.write(55); // Ensure catcher is open at the start
  myServo2.detach(); // Ensure servo2 is inactive initially
}

void loop() { 
    // Process serial input for conveyor control
    if (Serial.available()) {
        String command = Serial.readStringUntil('\n');
        
        if (command == "START") {
            digitalWrite(relay, LOW); // Start conveyor
            Serial.println("Conveyor Started");
        } else if (command == "STOP") {
            digitalWrite(relay, HIGH); // Stop conveyor
            Serial.println("Conveyor Stopped");
        } else if (command == "RESET") { 
            resetCounters();
        }
    }

    //color(); // Detect color

    if (digitalRead(ir_sensor1) == LOW) {
        delay(80);
        color(); // Detect color
        digitalWrite(buzzer, HIGH); // Sound buzzer
        digitalWrite(relay, HIGH);  // Stop conveyor
        delay(300);
        digitalWrite(buzzer, LOW);  // Turn off buzzer
        
        if ((red > blue && red > green) && (red > 100 && red < 280) && (green > 0 && green < 110) && (blue > 0 && blue < 110)) { 
            Serial.println("Red Color");
            x = "Red Color";
            redCount++;
        } 
        else if ((blue > red) && (blue < 250 && blue > 100) && (green > 90 && green < 250) && (red > 0 && red < 150)) { 
            Serial.println("Blue Color"); 
            x = "Blue Color";
            blueCount++;
        } 
        else if ((green > blue) && (green > 90 && green < 350) && (blue > 10 && blue < 290) && (red > 80 && red < 320)) { 
            Serial.println("Green Color"); 
            x = "Green Color";
            greenCount++;
        }  
        else {
            Serial.println("Defective Product");
            x = "Defective Product";
            defectiveProductCount++;
        }

        totalProductCount++;
        delay(2000);
        digitalWrite(relay, LOW); // Start conveyor again
        delay(20);
    }

    // Send data to C# application
    Serial.println("Red Count:" + String(redCount));
    Serial.println("Blue Count:" + String(blueCount));
    Serial.println("Green Count:" + String(greenCount));
    Serial.println("Total Count:" + String(totalProductCount));
    Serial.println("Defective Count:" + String(defectiveProductCount));

    if (digitalRead(ir_sensor2) == LOW) {
        delay(150);
        digitalWrite(buzzer, HIGH);
        digitalWrite(relay, HIGH); 
        delay(300);
        digitalWrite(buzzer, LOW);

        // Close catcher to grab the box
        myServo2.attach(6);
        closeCatcher();

        if (x == "Red Color") {
            moveServo(myServo1, 45);
        } else if (x == "Blue Color") {
            moveServo(myServo1, 90);
        } else if (x == "Green Color") {
            moveServo(myServo1, 135);
        } else if (x == "Defective Product") {
            moveServo(myServo1, 180);
        }

        delay(1000);
        openCatcher(); // Drop the box
        delay(1000);

        moveServo(myServo1, 0); // Reset robotic arm

        openCatcher(); // Ensure catcher remains open at the start position
        myServo2.detach(); // Disable catcher servo
        x = ""; // Reset color identifier
        delay(1000);
    }
}

// Function to move robotic arm to a specific position
void moveServo(Servo &servo, int position) {
    int currentPos = servo.read();
    int step = (position > currentPos) ? 1 : -1;

    for (int i = currentPos; i != position; i += step) {
        servo.write(i);
        delay(10);
    }
    servo.write(position);
}

// Function to open the catcher
void openCatcher() {
    for (int i = 30; i <= 55; i++) {
        myServo2.write(i);
        delay(5);
    }
}

// Function to close the catcher
void closeCatcher() {
    for (int i = 55; i >= 30; i--) {
        myServo2.write(i);
        delay(5);
    }
}

// Function to reset product counts
void resetCounters() {
    redCount = 0;
    greenCount = 0;
    blueCount = 0;
    totalProductCount = 0;
    defectiveProductCount = 0;
    Serial.println("Counters reset");
}

// Function to detect color
void color() {   
    digitalWrite(s2, LOW); 
    digitalWrite(s3, LOW); 
    red = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 
    digitalWrite(s3, HIGH); 
    blue = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 
    digitalWrite(s2, HIGH);
    green = pulseIn(out, digitalRead(out) == HIGH ? LOW : HIGH); 

    red = map(red,251,100,0,255);
    green = map(green,271,106,0,255);
    blue = map(blue,254,92,0,255);
}
