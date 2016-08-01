#include <LTHsensors.h>

const int numCham = 5;
Adafruit_HTU21DF htu[numCham];
Adafruit_TSL2561 tsl[numCham];
static char cham[6] = {'A','B','C','D','E','R'};
static uint8_t SDApin[6] = {18,17,16,15,14,7};
static uint8_t SCLpin = 19;

int i;
void setup() {
  Serial.begin(9600);
  Serial.println("Herb 114a Temperature/Light/Humidity sensors");
  
  for (i=0; i<numCham; i++)
  {
  
    //declare
    htu[i]=Adafruit_HTU21DF(SDApin[i],SCLpin);
    tsl[i]=Adafruit_TSL2561(SDApin[i],SCLpin,TSL2561_ADDR_FLOAT,i);

    //initialize
    if (!htu[i].begin()) 
    { Serial.println("No HTU21DF detected ..."); while (1); }
    if(!tsl[i].begin())
    { Serial.println("No TSL2561-1 detected ..."); while(1); }

    tsl[i].setIntegrationTime(TSL2561_INTEGRATIONTIME_101MS);  /* medium resolution and speed   */
  }
  
  Serial.println("");
  i=0;
}

void loop() {
  if(Serial.available()==0){}
  else{
    while(Serial.available()>0) {char t = Serial.read();}
    
    sensors_event_t event;
    tsl[i].getEvent(&event);
    Serial.print(cham[i]);
    Serial.print(" L: "); Serial.print(event.light);
    Serial.print(" T: "); Serial.print(htu[i].readTemperature());
    Serial.print(" H: "); Serial.print(htu[i].readHumidity());
    Serial.println("");
    Serial.flush();
  
    delay(200);
    
    i=(i+1)%numCham;
  }
}
