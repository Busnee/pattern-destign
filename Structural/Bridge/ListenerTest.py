from pynput.keyboard import Key, Listener
from pynput.mouse import Listener
from pynput import keyboard
import time

# keyboard.add_hotkey('ctrl + shift + z', print('hotkey'))

break_program = False
def on_press(key):
    global break_program
    print("key is pressed, " + format(key))
    if(format(key).lower() == 'q'):
        break_program = True
        print("exit the program")
        return False
        
def on_click(x, y, button, pressed):
    if pressed:
        print("Mouse clicked, " + str(x) + "," + str(y))


# key_listener = keyboard.Listener(on_press=on_press)
# key_listener.start()

# with Listener(on_click=on_click) as listener:
#     listener.join()

listener = Listener(on_click=on_click)
listener.start()
    
with keyboard.Listener(on_press=on_press) as listener:
    while break_program == False:
        pass
    listener.join()

