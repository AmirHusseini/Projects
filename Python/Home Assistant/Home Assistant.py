import datetime
import speech_recognition as sr
import pyttsx3


engine = pyttsx3.init()
engine.setProperty('rate', 200)
engine.setProperty('volume', 0.9)


def get_audio():
    r = sr.Recognizer()
    speech = sr.Microphone()

    with speech as source:
        audio = r.adjust_for_ambient_noise(source)
        audio = r.listen(source)
        said = ""
        try:
            said = r.recognize_google(audio, language = 'en-US')
            print(said)
            
        except sr.UnknownValueError:
            print("Could not understand!")

        except sr.RequestError as e:
            print("Could not request results from Speech Recognition service; {0}".format(e))

    return said.lower()

def speaking(text):
    engine = pyttsx3.init()
    engine.say(text)
    engine.runAndWait()

WAKE = "hi blue"

while True:
    print("Listening")
    text = get_audio()
    
    if text.count(WAKE) > 0:
        speaking("Hello, how can i help you?")
        text = get_audio()
        
        DISC = ["whats up", "how are you", "how is it going"]
        for phrase in DISC:
            if phrase in text:
                speaking("I am good, how about you?")            
        if 'time' in text:
            strTime = datetime.datetime.now().strftime("%H:%M")
            speaking(f"the current time is {strTime}")