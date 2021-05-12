import datetime    #DATETIME
import speech_recognition as sr    #RECOGNIZE VOICE USING MICROPHONE
import pyttsx3    #TEXT_TO_SPEECH
import subprocess #OPEN PROGRAMS
import pocketsphinx #Offline speech_recognition
from gpiozero import LED #Control GPIO
from time import sleep

red = LED(12)

#GET THE VOICE FROM MICROPHONE
def get_audio():
    r = sr.Recognizer()
    speech = sr.Microphone(device_index=2) #To choose specific microphone if you know which index(device_index=2)

    with speech as source:
        #audio = r.adjust_for_ambient_noise(source)# listen for 1 second to calibrate the energy threshold for ambient noise levels
        r.pause_threshold = 1
        audio = r.listen(source)
        said = ""
        try:
            #said = r.recognize_google(audio, language = 'en-US')
            said = r.recognize_sphinx(audio)
            print(said)
            
        except sr.UnknownValueError:
            print("Could not understand!")

        except sr.RequestError as e:
            print("Could not request results from Speech Recognition service; {0}".format(e))

    return said.lower()
    
#TEXT_TO_SPEECH
def speak(text):
    engine = pyttsx3.init()
    engine.setProperty('rate', 200)
    engine.setProperty('volume', 0.9)
    engine.say(text)
    engine.runAndWait()

#Wishing good day
def tellMe():
    hour = int(datetime.datetime.now().hour)
    if hour>= 0 and hour<12:
        speak("Good Morning!")

    elif hour>= 12 and hour<18:
        speak("Good Afternoon!")

    else:
        speak("Good Evening!")

    assistanten =("Blue")
    speak("I am your Assistant")
    speak(assistanten)

#MAKING A NOTE
def note(text):
    date = datetime.datetime.now()
    file_name = str(date).replace(":", "-") + "-note.txt"
    with open(file_name, "w") as f:
        f.write(text)
 
    subprocess.Popen(["mousepad", file_name])
    
#WAKE UP ASSISTANT WORD
WAKE = "assistant"

while True:
    print("Listening . . .")
    text = get_audio()
    
    if text.count(WAKE) > 0:
        tellMe()
        speak("how can i help you?")
        text = get_audio()
        
#CONVERSATION        
        DISC = ["whats up", "how are you", "how is it going"]
        for phrase in DISC:
            if phrase in text:
                speak("I am good, how about you?")
#TIME                
        if 'time' in text:
            strTime = datetime.datetime.now().strftime("%H:%M")
            speak(f"the current time is {strTime}")
#MAKE NOTE            
        NOTE_STRS = ["make a note", "write this down", "remember this"]
        for phrase in NOTE_STRS:
            if phrase in text:
                speak("what would you like me to note?")
                note_text = get_audio()
                note(note_text)
                speak("I have made a note of that.")
#Turning light on and off 
        if 'light on' in text:
            speak("turning on the light")
            red.on()
        if 'light off' in text:
            speak("turning off the light")
            red.off()