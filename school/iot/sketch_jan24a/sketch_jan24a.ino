
 void setup() {
pinMode(button, INPUT);
pinMode(led, OUTPUT);
pinMode(speaker, OUTPUT);
}




int buttonState = LOW;
void loop() {
if(digitalRead(button) !=buttonState) {
if(buttonState == LOW) {
digitalWrite(led, HIGH);
tone(speaker, 440);
buttonState = HIGH;
}
else {
digitalWrite(led, LOW);
noTone(speaker);
buttonState = LOW;
}
}
}
