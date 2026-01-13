#include <Servo.h>

// Servo motors
Servo myServo1; // Rotation Servo
Servo myServo2; // Catcher Servo

// Sensors & Actuators
const int ir_sensor1 = 2;
const int ir_sensor2 = 4;
const int buzzer = 3;
const int relay = 13;
const int s2 = 12; 
const int s3 = 11; 
const int out = 10;

// Ultrasonic Sensor Pins
const int trigPin = 9;
const int echoPin = 8;

// Product counters
int redCount = 0;
int greenCount = 0;
int blueCount = 0;
int totalProductCount = 0;
int defectiveProductCount = 0;
int defectiveDimensionCount = 0;

// Variables
int red = 0, green = 0, blue = 0;
float measuredHeight = 0.0;
float acceptedHeight = 5.0; // Default accepted height, updated from C#  
String x = "";

void setup() { 
    Serial.begin(9600);
    
    pinMode(ir_sensor1, INPUT);
    pinMode(ir_sensor2, INPUT);
    pinMode(buzzer, OUTPUT);
    pinMode(relay, OUTPUT);
    
    digitalWrite(relay, HIGH); // Conveyor off initially

    pinMode(s2, OUTPUT); 
    pinMode(s3, OUTPUT); 
    pinMode(out, INPUT);

    pinMode(trigPin, OUTPUT);
    pinMode(echoPin, INPUT);

    myServo1.attach(5);
    myServo2.attach(6);
    
    myServo1.write(0);
    myServo2.write(55);
    myServo2.detach();
}

void loop() { 
    // Process serial input from C#
    if (Serial.available()) {
        String command = Serial.readStringUntil('\n');
        
        if (command == "START") {
            digitalWrite(relay, LOW);
            Serial.println("Conveyor Started");
        } else if (command == "STOP") {
            digitalWrite(relay, HIGH);
            Serial.println("Conveyor Stopped");
        } else if (command.startsWith("SET_DIMENSIONS")) {
            acceptedHeight = command.substring(15).toFloat();
            Serial.println("Accepted Height Set: " + String(acceptedHeight) + " cm");
        } else if (command == "RESET") {
            resetCounters();
        }
    }

    if (digitalRead(ir_sensor1) == LOW) {
        delay(80);
        color(); // Detect color
        digitalWrite(buzzer, HIGH);
        digitalWrite(relay, HIGH);
        delay(300);
        digitalWrite(buzzer, LOW);
        
        // Classify color
        classifyColor();


        totalProductCount++;
        delay(2000);
        digitalWrite(relay, LOW);
    }

    // Send data to C# application
    Serial.println("Red Count:" + String(redCount));
    Serial.println("Blue Count:" + String(blueCount));
    Serial.println("Green Count:" + String(greenCount));
    Serial.println("Good Total Count:" + String(totalProductCount - defectiveProductCount));
    Serial.println("Defective Count:" + String(defectiveProductCount));
    

    if (digitalRead(ir_sensor2) == LOW) {
        delay(150);
        digitalWrite(buzzer, HIGH);
        digitalWrite(relay, HIGH);
        delay(300);
        digitalWrite(buzzer, LOW);
        

        // Measure height
        measuredHeight = measureHeight();
        Serial.println("Measured Height: " + String(measuredHeight, 2) + " cm");

        // Dimension Check
        if (abs(measuredHeight - acceptedHeight) > 0.5) { // 0.5 cm tolerance
            Serial.println("✖ STATUS: MISMATCH");
            defectiveDimensionCount++;
        } else {
            Serial.println("✔ STATUS: OK");
        }

        // Send data to C# application
        Serial.println("Dimension Defective Count:" + String(defectiveDimensionCount));

        delay(2000);

        // Close catcher
        myServo2.attach(6);
        closeCatcher();
        //delay(500);
        // Move robotic arm to position
        moveArm(x);

        delay(1000);
        openCatcher();
        delay(1000);

        // Reset arm
        moveServo(myServo1, 0);
        openCatcher();
        myServo2.detach();
        x = "";
        delay(1000);
    }
}

// Function to classify color
void classifyColor() {
    if ((red > blue && red > green) && (red > 100 && red < 280) && (green > 0 && green < 110) && (blue > 0 && blue < 110)) { 
        Serial.println("Red Color");
        x = "Red Color";
        redCount++;
    } else if ((blue > red) && (blue < 250 && blue > 100) && (green > 90 && green < 250) && (red > 0 && red < 150)) { 
        Serial.println("Blue Color"); 
        x = "Blue Color";
        blueCount++;
    } else if ((green > blue) && (green > 90 && green < 350) && (blue > 10 && blue < 290) && (red > 80 && red < 320)) { 
        Serial.println("Green Color"); 
        x = "Green Color";
        greenCount++;
    } else {
        Serial.println("Defective Product");
        x = "Defective Product";
        defectiveProductCount++;
    }
}

// Function to measure height using ultrasonic sensor
float measureHeight() {
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);

    long duration = pulseIn(echoPin, HIGH);
    float distance = duration * 0.0343 / 2;
    return distance;
}

// Function to move robotic arm
void moveArm(String color) {
  delay(1000);
    if (color == "Red Color") {
        moveServo(myServo1, 45);
    } else if (color == "Blue Color") {
        moveServo(myServo1, 90);
    } else if (color == "Green Color") {
        moveServo(myServo1, 135);
    } else if (color == "Defective Product") {
        moveServo(myServo1, 180);
    }
}

// Function to move servo to position
void moveServo(Servo &servo, int position) {
    int currentPos = servo.read();
    int step = (position > currentPos) ? 1 : -1;

    for (int i = currentPos; i != position; i += step) {
        servo.write(i);
        delay(10);
    }
    servo.write(position);
}

// Function to open catcher
void openCatcher() {
    for (int i = 30; i <= 55; i++) {
        myServo2.write(i);
        delay(5);
    }
}

// Function to close catcher
void closeCatcher() {
    for (int i = 55; i >= 30; i--) {
        myServo2.write(i);
        delay(5);
    }
}

// Function to reset counters
void resetCounters() {
    redCount = 0;
    greenCount = 0;
    blueCount = 0;
    totalProductCount = 0;
    defectiveProductCount = 0;
    defectiveDimensionCount = 0;
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
