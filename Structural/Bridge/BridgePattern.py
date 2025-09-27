from abc import ABC, abstractmethod
from pynput.keyboard import Key, Listener
from pynput.mouse import Listener
from pynput import keyboard, mouse

class PaintApp(ABC) :
    # the variable below are static variable
    BRUSH_TOOL = "BRUSH"
    ERASE_TOOL = "ERASE"
    EYE_DROPPER_TOOL = "EYE_DROPPER"
    
    # the variable below are private attribute
    __name: str
    __currentTool: str  
       
    def __init__(self, name):
        self.__name = name
        self.__currentTool = PaintApp.BRUSH_TOOL
        print("Create " + self.__name + " Application")
    def getName(self):
        return self.__name
    def setCurrentTool(self, tool):
        self.__currentTool = tool
    def getCurrentTool(self):
        return self.__currentTool
    @abstractmethod
    def pressKey(key):
        pass
    @abstractmethod
    def click(x, y, button, pressed):
        pass
    def zoomIn(self):
        print(self.__name + " : zoom in")
    def zoomOut(self):
        print(self.__name + " : zoom out")
    def undo(self):
        print(self.__name + " : undo")
    def redo(self):
        print(self.__name + " : redo")
    def brushTool(self):
        self.__currentTool = self.BRUSH_TOOL
        print(self.__name + " : use brush tool")
    def eraseTool(self):
        self.__currentTool = self.ERASE_TOOL
        print(self.__name + " : use erase tool")
    def eyeDropperTool(self):
        self.__currentTool = self.EYE_DROPPER_TOOL
        print(self.__name + " : use eye dropper tool")
    
class Krita(PaintApp):
    def __init__(self):
        super().__init__(name="Krita")
    def pressKey(self, key):
        # print("Krita key press.")
        k = format(key)
        if(k == "<107>"):   # ctrl + (+)
            self.zoomIn()
        elif(k == "<109>"): # ctrl + (-)
            self.zoomOut()
        elif(k == "\'\\x1a\'"): # ctrl + z
            self.undo()
        elif(k == "\'y\'"): # use y instead of ctrl + shift + z 
            self.redo()
        elif(k == "\'b\'"):
            self.brushTool()
        elif(k == "\'e\'"):
            self.eraseTool()
        elif(k == "\'p\'"):
            self.eyeDropperTool()        
    def click(self, x, y, button, pressed):
        # print("Krita click.", self.get)    
        if self.getCurrentTool() == PaintApp.BRUSH_TOOL:
            print("Krita " + self.getName() + ": paint at " + str(x) + " , " + str(y) )
        elif self.getCurrentTool() == PaintApp.ERASE_TOOL:
            print("Krita " + self.getName() + ": erase at " + str(x) + " , " + str(y) )
        elif self.getCurrentTool() == PaintApp.EYE_DROPPER_TOOL:
            print("Krita " + self.getName() + ": get color form " + str(x) + " , " + str(y) )
            self.setCurrentTool(PaintApp.BRUSH_TOOL)
    def showShortcuts(self):
        result = '''
                Krita Shortcuts
        ctrl + (+)      Zoom In
        ctrl + (-)      Zoom Out
        ctrl + z        Undo
        y               Redo
        b               Brush Tool
        e               Erase Tool
        p               Eye Dropper Tool
        esc             Exit
        '''
        print(result)
    
class ClipStudio(PaintApp):
    def __init__(self):
        super().__init__(name="Clip Studio")
    def pressKey(self, key):
        # print("Clip Studio key press.")
        k = format(key)
        if(k == "<107>"):   # ctrl + (+)
            self.zoomIn()
        elif(k == "<109>"): # ctrl + (-)
            self.zoomOut()
        elif(k == "\'\\x1a\'"): # ctrl + z
            self.undo()
        elif(k == "\'\\x19\'"): # ctrl + y
            self.redo()
        elif(k == "\'b\'"):
            self.brushTool()
        elif(k == "\'e\'"):
            self.eraseTool()
        elif(k == "\'i\'"):
            self.eyeDropperTool()
    def click(self, x, y, button, pressed):
        # print("click function")
        if self.getCurrentTool() == PaintApp.BRUSH_TOOL:
            print("Clip Studio " + self.getName() + ": paint at " + str(x) + " , " + str(y) )
        elif self.getCurrentTool() == PaintApp.ERASE_TOOL:
            print("Clip Studio " + self.getName() + ": erase at " + str(x) + " , " + str(y) )
        elif self.getCurrentTool() == PaintApp.EYE_DROPPER_TOOL:
            print("Clip Studio " + self.getName() + ": get color form " + str(x) + " , " + str(y) )
            self.setCurrentTool(PaintApp.BRUSH_TOOL)
        # print("before click function")
    def showShortcuts(self):
        result = '''
            Clip Studio Shortcuts
        ctrl + (+)      Zoom In
        ctrl + (-)      Zoom Out
        ctrl + z        Undo
        ctrl + y        Redo
        b               Brush Tool
        e               Erase Tool
        i               Eye Dropper Tool
        esc             Exit
        '''
        print(result)
    
class GraphicsTablet:
    __app:PaintApp
    __penButton1:str
    __penButton2:str
    __nTableKey:int
    __tabletKeys: list
    __keyboard_listener:Listener
    __mouse_listener:Listener
        
    
    def __init__(self, app:PaintApp, nTabletKey:int):
        self.__app = app
        self.__nTableKey = nTabletKey
        self.__penButton1 = "\'b\'"
        self.__penButton2 = "\'e\'"
        self.__tabletKeys = [''] * nTabletKey  
        self.__keyboard_listener = None
        self.__mouse_listener = None
         
    def setApp(self, app:PaintApp):
        self.__app = app
    def startApp(self):
        self.__keyboard_listener = keyboard.Listener(on_press=self.on_press)
        self.__mouse_listener = mouse.Listener(on_click=self.on_click)
        self.__keyboard_listener.start()
        self.__mouse_listener.start()
        self.__keyboard_listener.join()
        self.__mouse_listener.join()    
            
    def stopApp(self):
        self.__keyboard_listener.stop()
        self.__mouse_listener.stop()
    
    def setPenButton1(self, key:str):
        self.__penButton1 = key.lower()
    def setPenButton2(self, key:str):
        self.__penButton2 = key.lower()
    def setTabletKey(self, index:int, key:str):
        if((index < 0) or (index > self.__nTableKey-1)):
            return
        self.__tabletKeys[index] = key.lower()
    def getApp(self):
        return self.__app
    def getPenButton1(self):
        return self.__penButton1
    def getPenButton2(self):
        return self.__penButton2
    def getTabletKeys(self):
        return self.__tabletKeys
    def showKey(self):
        print("Pen button1: " + self.__penButton1)
        print("Pen button2: " + self.__penButton2)
        for i in range(self.__nTableKey):
            print("Tablet Key" + str(i+1) + ": " + self.__tabletKeys[i])
    
    @abstractmethod
    def on_press(key):
        pass
    @abstractmethod
    def on_click(key):
        pass
    
class Wacom(GraphicsTablet):
    def __init__(self, app:PaintApp, nTabletKey:int):
        super().__init__(app, nTabletKey)
        print("Create Wacom Graphics Tablet.")
    def on_press(self, key):
        if(not self.connectedApp()):
            return
        k = format(key).lower()
        if(k == "key.esc"):
            print("Exit " + self.getApp().getName())
            self.stopApp()
            self.setApp(None)
            return
        if(k == self.getPenButton1() or k == self.getPenButton2()):
            print("Wacom press key:" + k)
            self.getApp().pressKey(key)
            return
        for hotkey in self.getTabletKeys():
            if(k == hotkey):
                print("Wacom press key:" + k)
                self.getApp().pressKey(key)
                return
    def on_click(self, x, y, button, pressed):
        if pressed:
            if(not self.connectedApp()):
                return
            print("Wacom click at: " + str(x) + " , " + str(y))
            self.getApp().click(x, y, button, pressed)
    def connectedApp(self) -> bool:
        if(self.getApp() == None):
            # print("Wacom: no app connected")
            return False
        return True

class Veikk(GraphicsTablet):
    def __init__(self, app:PaintApp, nTabletKey:int):
        super().__init__(app, nTabletKey)
        print("Create Veikk Graphics Tablet.")
    def on_press(self, key):
        if(not self.connectedApp()):
            return
        k = format(key).lower()
        if(k == "key.esc"):
            print("Exit " + self.getApp().getName())
            self.stopApp()
            self.setApp(None)
            return
        if(k == self.getPenButton1() or k == self.getPenButton2()):
            print("Veikk press key:" + k)
            self.getApp().pressKey(key)
            return
        for hotkey in self.getTabletKeys():
            if(k == hotkey):
                print("Veikk press key:" + k)
                self.getApp().pressKey(key)
                return
    def on_click(self, x, y, button, pressed):
        if pressed:
            if(not self.connectedApp()):
                return
            print("Veikk click at: " + str(x) + " , " + str(y))
            self.getApp().click(x, y, button, pressed)
    def connectedApp(self) -> bool:
        if(self.getApp() == None):
            # print("Veikk: no app connected")
            return False
        return True