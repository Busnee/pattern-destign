from abc import ABC, abstractmethod
from PIL import Image, ImageDraw

# interface
class Memento(ABC):
    @abstractmethod
    def restore():
        pass
    
#interface
class Originator(ABC):
    @abstractmethod
    def save() -> Memento:
        pass

class CareTaker:
    __history:list  # list of Memento
    def __init__(self):
        self.__history = []
    def addMemento(self, memento:Memento):
        self.__history.append(memento)
    def undo(self):
        if self.__history.__len__() > 0:
            memento:Memento = self.__history.pop()
            memento.restore()
    def getHistory(self):
        return self.__history
    
class Picture(Originator):
    __image:Image
    
    def __init__(self, img:Image):
        self.__image = img.copy()
    def save(self) -> Memento:
        return PictureMemento(originator=self, img=self.__image)
    def setImage(self, img:Image):
        self.__image = img.copy()
    def getImage(self):
        return self.__image
    
class PictureMemento(Memento):
    __originator:Picture
    __image:Image
    
    def __init__(self, originator:Picture, img:Image):
        self.__originator = originator
        self.__image = img.copy()
    def restore(self):
        self.__originator.setImage(self.__image)
     
class Sticker(Originator):
    __image:Image
    __mask:Image
    
    def __init__(self, img:Image):
        super().__init__()
        self.__image = img.copy()
        
        mask_img = Image.new(mode="L",size=self.__image.size, color=0)
        draw = ImageDraw.Draw(mask_img)
        draw.ellipse(xy=(0, 0, mask_img.size[0], mask_img.size[1]), fill=255)
        
        self.__mask = mask_img.copy()
    def save(self) -> Memento:
        return StickerMemento(originator=self, img=self.__image, mask=self.__mask)
    def setImage(self, img: Image):
        self.__image = img.copy()
    def setMask(self, mask: Image):
        self.__mask = mask
    def getImage(self):
        return self.__image
    def getMask(self):
        return self.__mask
    def makeSticker(self):
        back_img = Image.new(mode="RGB",size=self.__image.size, color=(255,255,255))
        back_img.paste(self.__image, (0,0), self.__mask)
        return back_img
    
class StickerMemento(Memento):
    __originator:Sticker
    __image:Image
    __mask:Image
    
    def __init__(self, originator:Sticker, img:Image, mask:Image):
        super().__init__()
        self.__originator = originator
        self.__image = img.copy()
        self.__mask = mask.copy()
    def restore(self):
        self.__originator.setImage(self.__image)
        self.__originator.setMask(self.__mask)
