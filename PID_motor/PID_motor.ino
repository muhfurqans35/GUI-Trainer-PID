String mySt = "";
char myChar;
boolean stringComplete = false;
boolean motor_start = true;
const byte pin_a = 2;   //Encoder
const byte pin_fwd = 5; //for H-bridge: run motor forward
const byte pin_bwd = 4; //for H-bridge: run motor backward
const byte pin_pwm = 3; //for H-bridge: motor speed
int encoder = 0;
int m_direction = 0;
double pv_speed = 0;
double set_speed = 0;
double e_speed = 0; //error dari kecepatan = set_speed - pv_speed
double e_speed_pre = 0;  //error terakhir dari kecepatan
double e_speed_sum = 0;  //jumlah error dari kecepatan
double pwm_pulse = 0;
double kp = 0;
double ki = 0;
double kd = 0;
int timer1_counter; //for timer
int i = 0;

void setup() {
 
  pinMode(pin_fwd, OUTPUT);
  pinMode(pin_bwd, OUTPUT);
  pinMode(pin_pwm, OUTPUT);
  attachInterrupt(digitalPinToInterrupt(pin_a), detect_a, RISING);
  Serial.begin(9600);
  noInterrupts();
  TCCR1A = 0;
  TCCR1B = 0;
  timer1_counter = 34286;


  TCNT1 = timer1_counter;
  TCCR1B |= (1 << CS12);
  TIMSK1 |= (1 << TOIE1);
  interrupts();

  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
  analogWrite(pin_pwm, 0);  //stop motor
  digitalWrite(pin_fwd, 1); //stop motor
  digitalWrite(pin_bwd, 0); //stop motor
}

void loop() {
  if (stringComplete) {
    mySt = "";
    stringComplete = false;
  }

  //Menerima perintah dari Visual basic
  if (mySt.substring(0, 8) == "vs_start") {
    digitalWrite(pin_fwd, 1);     //menjalankan motor kedepan
    digitalWrite(pin_bwd, 0);
    motor_start = true;
  }
  if (mySt.substring(0, 7) == "vs_stop") {
    digitalWrite(pin_fwd, 0);
    digitalWrite(pin_bwd, 0);     //menghentikan motor
    motor_start = false;
  }
  if (mySt.substring(0, 12) == "vs_set_point") {
    set_speed = mySt.substring(12, mySt.length()).toFloat();
  }
  if (mySt.substring(0, 5) == "vs_kp") {
    kp = mySt.substring(5, mySt.length()).toFloat();
  }
  if (mySt.substring(0, 5) == "vs_ki") {
    ki = mySt.substring(5, mySt.length()).toFloat();
  }
  if (mySt.substring(0, 5) == "vs_kd") {
    kd = mySt.substring(5, mySt.length()).toFloat();
  }
  if (mySt.substring(0, 6) == "vs_pwm") {
  pwm_pulse = mySt.substring(6, mySt.length()).toFloat();
  }
}

void detect_a() {
  encoder += 1;
}
ISR(TIMER1_OVF_vect)
{
  TCNT1 = timer1_counter;   // set timer
  pv_speed = 600.0 * (encoder / 200.0) / 1; //menghitung speed motor, dalam rpm
  encoder = 0;
  //print out speed
  if (Serial.available() <= 0) {
    Serial.print("speed");
    Serial.println(pv_speed);
  }

  //PID program
  if (motor_start) {
    e_speed = set_speed - pv_speed;
    pwm_pulse = e_speed * kp + e_speed_sum * ki + (e_speed - e_speed_pre) * kd;
    e_speed_pre = e_speed;  //Menyimpan error terakhir sebelumnya
    e_speed_sum += e_speed; //jumlah error
    if (e_speed_sum > 4000) e_speed_sum = 4000;
    if (e_speed_sum < -4000) e_speed_sum = -4000;
  }

  else {
    e_speed = 0;
    e_speed_pre = 0;
    e_speed_sum = 0;
    pwm_pulse = 0;
  }
  if (pv_speed > 2000) {
    pv_speed = 0;
  }
  if (pwm_pulse < 0) {
    pwm_pulse = 0;
  }
  //update new speed
  if (pwm_pulse <255 & pwm_pulse >0) {
    analogWrite(pin_pwm, pwm_pulse);
  }
  else {
    if (pwm_pulse > 255) {
      analogWrite(pin_pwm, 255);
    }
    else {
      analogWrite(pin_pwm, 0);
    }
  }

}
void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    if (inChar != '\n') {
      mySt += inChar;
    }
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
