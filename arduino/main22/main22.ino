#define MQ2pin (0)
#include <SPI.h>                          //SPI kütüphanemizi tanımlıyoruz.
#include <MFRC522.h>                      //MFRC522 kütüphanemizi tanımlıyoruz.
#include <Servo.h>                        //Servo kütüphanemizi tanımlıyoruz.
#define gassensor_pin A0
#define sicakliksensor_pin A2
#define motor_pin1 5
#define motor_pin2 6
#define nemsensor_pin A1
#define RST_PIN 9
#define SS_PIN 10
#define servo_pin 8
#define buzzer_pin 7
//void sicaklikhesap();
//void nemhesap();
//void gashesap();
//void rfidhesap();

char c;
String appendSerialData;
Servo servo1;
MFRC522 rfid(SS_PIN, RST_PIN);
int gassensor1;
int sicaklik1;
int nemsensor1;
int gassensor;

float isi;
int nem;
int motor;
   byte ID[4] = {166 , 24, 48, 248}; 
void sicaklikhesap(){
  
float isi= analogRead(sicakliksensor_pin);
  float c=(isi/10230)*5000;
  Serial.print(c);
  
  
  }
  void kapikontrol(int motor ){
    servo1.write(motor);
    
    }
  void gashesap(){
    
    gassensor = analogRead(gassensor_pin);
    
    Serial.print(gassensor);
    }
  void nemhesap(){
    nem=analogRead(nemsensor_pin);
    Serial.print(nem);
    } 
  void rfidhesap(){
    int control = 0;
    while(control == 0){
      
      
  
       if ( ! rfid.PICC_IsNewCardPresent())    //Yeni kartın okunmasını bekliyoruz.
    continue;

       if ( ! rfid.PICC_ReadCardSerial())      //Kart okunmadığı zaman bekliyoruz.
    continue;

  if (rfid.uid.uidByte[0] == ID[0] &&     //Okunan kart ID'si ile ID değişkenini karşılaştırıyoruz.
    rfid.uid.uidByte[1] == ID[1] && 
    rfid.uid.uidByte[2] == ID[2] && 
    rfid.uid.uidByte[3] == ID[3] ) {
   Serial.println("Yetkili Kart");
   control = 1;
    }
    else{                                 //Yetkisiz girişte içerideki komutlar çalıştırılır.
      Serial.println("Yetkisiz Kart");
      control = 1;
    }
  rfid.PICC_HaltA();
    }
}
void setup() {
  
 Serial.begin(9600); 
 SPI.begin();
 pinMode(sicakliksensor_pin,INPUT);
 pinMode(nemsensor_pin,INPUT);
 pinMode(motor_pin1,OUTPUT); 
 pinMode(motor_pin2,OUTPUT);
 pinMode(buzzer_pin,OUTPUT);
 rfid.PCD_Init(); 
 servo1.attach(3); 

}

void loop() {
while(Serial.available()>0)
{
 c =Serial.read(); 
 appendSerialData += c;
 
}
gassensor1 = analogRead(gassensor_pin);
sicaklik1 = analogRead(sicakliksensor_pin);
nemsensor1 = analogRead(nemsensor_pin);

Serial.print((String) gassensor1 + "A" + nemsensor1 +"B" + sicaklik1 + "C" + "\n");
delay(200);
 if(c == '#'){
  if(appendSerialData == "1#"){

    
      sicaklikhesap();
      Serial.println(" ");
  }
      
   else if(appendSerialData == "2#"){

    
      nemhesap();
      Serial.println(" ");
  }
   else if(appendSerialData == "3#"){

    
      gashesap();
      Serial.println(" ");
  }
      
    else if(appendSerialData == "4#"){

    
      rfidhesap();
      Serial.println(" ");
  }
    else if(appendSerialData == "5#"){
    
    
    motor = 180;
    kapikontrol(motor);
    
    
    }
    else if(appendSerialData == "6#"){
    motor = 0;
    kapikontrol(motor);
    }
    else if(appendSerialData == "7#"){
      digitalWrite(motor_pin1,HIGH);
      digitalWrite(motor_pin2,LOW);
      
      
      
      }
    else if(appendSerialData == "8#"){
      digitalWrite(motor_pin1,LOW);
      digitalWrite(motor_pin2,LOW);
      
      
      }
      else if(appendSerialData == "9#")
      {
        digitalWrite(buzzer_pin,HIGH);
        delay(1000);
        digitalWrite(buzzer_pin,LOW);
      }
    
  appendSerialData = "";
  c = 0;
    
    
    }
    
        
  
     
 }

   



      
      
