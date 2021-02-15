import RPi.GPIO as GPIO
import dht11
import time
import datetime

# initialize GPIO
GPIO.setwarnings(False)
GPIO.setmode(GPIO.BCM)
GPIO.cleanup()

# read data using pin 17
instance = dht11.DHT11(pin=17)

while True:
    result = instance.read()
    if result.is_valid():
        Temperature = result.temperature
        Humidity = result.humidity
        TIME = datetime.datetime.now() 


        print(Temperature, Humidity, TIME)

    time.sleep(2)

