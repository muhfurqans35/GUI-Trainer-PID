#include "Wire.h"
#include <OneWire.h>
#include <Wire.h>

String mySt = "";
char myChar;
boolean stringComplete = false;  // whether the string is complete

OneWire  ds(10);  // on pin 10 (a 4.7K resistor is necessary)

double kp =0;
double ki =0;
double kd =0;

double p,ix,d,pv_aktual,pid;
double error,errorx,sumerr;

double sp;   
double set_point = 0;  //set point
int pinpwm = 9;

int timer1_counter; //for timer

 byte i;
  byte present = 0;
  byte type_s;
  byte data[12];
  byte addr[8];
  float celsius, fahrenheit;


void setup() {

  pinMode(pinpwm,OUTPUT);
  Serial.begin(9600);
  //--------------------------timer setup
  noInterrupts();           // disable all interrupts
  TCCR1A = 0;
  TCCR1B = 0;
  timer1_counter = 59286;   // preload timer 65536-16MHz/256/2Hz (34286 for 0.5sec) (59286 for 0.1sec)

  
  TCNT1 = timer1_counter;   // preload timer
  TCCR1B |= (1 << CS12);    // 256 prescaler 
  TIMSK1 |= (1 << TOIE1);   // enable timer overflow interrupt
  interrupts();             // enable all interrupts
  //--------------------------timer setup
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
}
void loop() {

 if (stringComplete) {
    // clear the string when COM receiving is completed
    mySt = "";  //note: in code below, mySt will not become blank, mySt is blank until '\n' is received
    stringComplete = false;
  }

  if (mySt.substring(0,12) == "vs_set_point"){
    set_point = mySt.substring(12,mySt.length()).toFloat();  //get string after set_speed
  }
  if (mySt.substring(0,5) == "vs_kp"){
    kp = mySt.substring(5,mySt.length()).toFloat(); //get string after vs_kp
  }
  if (mySt.substring(0,5) == "vs_ki"){
    ki = mySt.substring(5,mySt.length()).toFloat(); //get string after vs_ki
  }
  if (mySt.substring(0,5) == "vs_kd"){
    kd = mySt.substring(5,mySt.length()).toFloat(); //get string after vs_kd
  }  

}
  
ISR(TIMER1_OVF_vect)        // interrupt service routine - tick every 0.1sec
 {
   TCNT1 = timer1_counter;   // set timer
     //PID Program
 
   if (Serial.available() <= 0) {
    Serial.print("temps");
    Serial.println(pv_aktual);//Print speed (rpm) value to Visual Studio
    }
  //update suhu
     
  if ( !ds.search(addr)) {
    ds.reset_search();
   
    return;
  }

  for( i = 0; i < 8; i++) {

  }

  if (OneWire::crc8(addr, 7) != addr[7]) {
      return;
  }

  switch (addr[0]) {
    case 0x10:
      type_s = 1;
      break;
    case 0x28:
      type_s = 0;
      break;
    case 0x22:
      type_s = 0;
      break;
    default:
      return;
  }

  ds.reset();
  ds.select(addr);
  ds.write(0x44, 1);        // start conversion, with parasite power on at the end

      // maybe 750ms is enough, maybe not

  present = ds.reset();
  ds.select(addr);  
  ds.write(0xBE);         // Read Scratchpad

  for ( i = 0; i < 9; i++) {           // we need 9 bytes
    data[i] = ds.read();
  }

  int16_t raw = (data[1] << 8) | data[0];
  if (type_s) {
    raw = raw << 3; // 9 bit resolution default
    if (data[7] == 0x10) {
      raw = (raw & 0xFFF0) + 12 - data[6];
    }
  } else {
    byte cfg = (data[4] & 0x60);
    if (cfg == 0x00) raw = raw & ~7;  // 9 bit resolution, 93.75 ms
    else if (cfg == 0x20) raw = raw & ~3; // 10 bit res, 187.5 ms
    else if (cfg == 0x40) raw = raw & ~1;} // 11 bit res, 375 ms
  celsius = (float)raw / 16.0;
  fahrenheit = celsius * 1.8 + 32.0;
  pv_aktual = celsius;
  sp = set_point + 30;  //atur range overlap kalibrasi
  
  error = sp - pv_aktual;
  p = error * kp;
  sumerr = error + errorx; 
  ix = ki * sumerr; 
  d = kd * (error - errorx);
  pid = p + ix + d;
  errorx = error;
  if (pid <255 & pid >0){
    analogWrite(pinpwm,pid);
  }
  else{
    if (pid>255){
      analogWrite(pinpwm,255);
    }
    else{
      analogWrite(pinpwm,0);
    }
  }
  }

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    if (inChar != '\n') {
      mySt += inChar;
    }
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
