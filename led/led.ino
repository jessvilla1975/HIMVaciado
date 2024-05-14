
int PinRele = 3;
String entrada = "";
bool completo = false;
int numero = 0;
int dato = 0;
int flowPin = 2; 
double flowRate; 
volatile int count;

void setup() {

  pinMode(flowPin, INPUT); // Sets the pin as an input
  attachInterrupt(0, Flow, RISING); 
  Serial.begin(9600);
  pinMode(PinRele, OUTPUT);
  digitalWrite(PinRele, LOW);
  delay(500);
}

void loop() {

  count = 0; // Reset the counter so we start counting from 0 again
  interrupts(); //Enables interrupts on the Arduino
  delay (1000); //Wait 1 second 
  noInterrupts(); //Disable the interrupts on the Arduino
  
  //Start the math
  flowRate = (count * 2.25); //Take counted pulses in the last second and
  //multiply by 2.25mL 
  flowRate = flowRate * 60; //Convert seconds to minutes, giving you mL / Minute
  flowRate = flowRate / 1000; //Convert mL to Liters, giving you Liters / Minute
  Serial.println(flowRate);
 
  if (completo) {
        entrada.trim();
        //Serial.println("Comando recibido: " + entrada); // Imprime el comando recibido
        if(entrada.equals("00")) {
          digitalWrite(PinRele, HIGH);
          delay(1000); // Retraso de 1 segundo
        } else if (entrada.equals("11111")) {
          digitalWrite(PinRele, LOW);
          delay(1000); // Retraso de 1 segundo
        }
        entrada = "";
        completo = false;
      }
  

}

void serialEvent() {
  while (Serial.available()) {
    char inchar = (char)Serial.read();
    if(inchar == '\n') {
      completo = true;
    } else {
      entrada += inchar;
    }
  }
}

void Flow()
{
 count++; //Every time this function is called, increment "count" by 1
}

