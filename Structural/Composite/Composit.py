from abc import ABC, abstractmethod

class Building(ABC):
    @abstractmethod
    def build():
        pass
    @abstractmethod
    def destroy():
        pass
    @abstractmethod
    def __str__():
        pass
    @abstractmethod
    def getCategory():
        pass
    
class Research(Building):
    __name: str
    __usePower: float
    def __init__(self, name:str, category:str, usePower:float):
        self.__name = name
        self.__category = category
        self.__usePower = usePower
    def build(self):
        print("build " + self.__name)
    def destroy(self):
        print("destroy " + self.__name)
    def __str__(self):
        answer = "Research Building: " + self.__name + "\n"
        answer += "\tcategory = " + self.__category + "\n"
        answer += "\tusePower = " + str(self.__usePower) + " W\n"
        return answer
    def getName(self):
        return self.__name
    def getCategory(self):
        return "Research"
    def getUsePower(self):
        return self.__usePower
    
class Power(Building):
    __name: str
    __material: str
    def __init__(self, name:str, category:str, material:str):
        self.__name = name
        self.__category = category
        self.__material = material
    def build(self):
        print("build " + self.__name)
    def destroy(self):
        print("destroy " + self.__name)
    def __str__(self):
        answer = "Power Building: " + self.__name + "\n"
        answer += "\tcategory = " + self.__category + "\n"
        answer += "\tmaterial = " + self.__material + "\n"
        return answer
    def getName(self):
        return self.__name
    def getCategory(self):
        return "Power"
    def getMaterial(self):
        return self.__material
    
class PowerGenerator(Power):
    __powerGenerate: float
    def __init__(self, name:str, category:str, material:str, powerGenerate:float):
        super().__init__(name, category, material)
        self.__powerGenerate = powerGenerate
    def build(self):
        print("build " + self.getName())
    def destroy(self):
        print("destroy " + self.getName())
    def __str__(self):
        answer = super().__str__()
        answer += "\tpowerGenerate = " + str(self.__powerGenerate) + " W\n"
        return answer
    def getPowerGenerate(self):
        return self.__powerGenerate
    def getCategory(self):
        return "PowerGenerator"
    
class Battery(Power):
    __powerCapacity_kJ: float
    def __init__(self, name:str, category:str, material:str, powerCapacity_kJ:float):
        super().__init__(name, category, material)
        self.__powerCapacity_kJ = powerCapacity_kJ
    def build(self):
        print("build " + self.getName())
    def destroy(self):
        print("destroy " + self.getName())
    def __str__(self):
        answer = super().__str__()
        answer += "\tpowerCapacity_kJ = " + str(self.__powerCapacity_kJ) + " kJ\n"
        return answer
    def getPowerCapacity_kJ(self):
        return self.__powerCapacity_kJ
    def getCategory(self):
        return "Battery"
    
class Wire(Power):
    __maxPower_kW:float
    def __init__(self, name:str, category:str, material:str, maxPower_kW:float):
        super().__init__(name, category, material)
        self.__maxPower = maxPower_kW
    def build(self):
        print("build " + self.getName())
    def destroy(self):
        print("destroy " + self.getName())
    def __str__(self):
        answer = super().__str__()
        answer += "\tmaxPower = " + str(self.__maxPower_kW) + " kW\n"
        return answer
    def getMaxPower(self):
        return self.__maxPower
    def getCategory(self):
        return "Wire"
    
class CompositeBuilding:
    __name: str
    __buildings: list   # list of Building
    def __init__(self, name:str):
        self.__name = name
        self.__buildings = []
    def add(self, building: Power):
        self.__buildings.append(building)
    def add(self, building: Research):
        self.__buildings.append(building)
    def build(self):
        print("...build " + self.__name + "...")
        for b in self.__buildings:
            b.build()
    def destroy(self):
        print("...destroy " + self.__name + "...")
        for b in self.__buildings:
            b.destroy()
    def __str__(self):
        return "CompositBuilding: " + self.__name
    def getName(self):
        return self.__name
    def getBuildings(self):
        return self.__buildings
    def getCategory():
        return "CompositeBuilding"
    
def main():
    switch = Power("Switch","PowerRegulator","Metal Ore")
    solarPanel = PowerGenerator("Solar Panel","PowerGenerator", "Glass", 380)
    steamTurbine = PowerGenerator("Steam Turbine","PowerGenerator","Refined Metal and Plastic", 850)
    battery = Battery("Battery", "Battery", "Metal Ore", 20)
    jumboBattery = Battery("Jumbo Battery", "Battery", "Metal Ore", 40)
    heaviWattWire = Wire("Heavi-Watt Wire","Wire","Metal Ore",20)
    wire = Wire("Wire", "Wire", "Metal Ore", 1)
    telescope = Research("Telescope", "Research", 120)
    superComputer = Research("Super Computer", "Research", 240)
    
    # Solar Power Section            
    solarPowerSection = CompositeBuilding("Solar Power Section")
    solarPowerSection.add(solarPanel)
    solarPowerSection.add(solarPanel)
    solarPowerSection.add(solarPanel)
    solarPowerSection.add(heaviWattWire)
    
    # Steam Turbine Power Section   
    steamTurbinePowerSection = CompositeBuilding("Steam Turbine Power Section")
    steamTurbinePowerSection.add(steamTurbine)
    steamTurbinePowerSection.add(heaviWattWire)
    
    # Battery Section
    batterySection = CompositeBuilding("Battery Section")
    batterySection.add(jumboBattery)
    batterySection.add(jumboBattery)
    batterySection.add(jumboBattery)
    batterySection.add(jumboBattery)
    batterySection.add(heaviWattWire)
    
    # Power Station
    powerStation = CompositeBuilding("Power Station")
    powerStation.add(solarPowerSection)
    powerStation.add(steamTurbinePowerSection)
    powerStation.add(batterySection)
    
    powerStation.build()
    print()
    
    # Research Station
    researchStation = CompositeBuilding("Research Station")
    researchStation.add(superComputer)
    researchStation.add(superComputer)
    researchStation.add(superComputer)
    researchStation.add(telescope)
    researchStation.add(telescope)
    researchStation.add(battery)
    researchStation.add(wire)
    researchStation.add(switch)
    
    reserchStationBuildings = researchStation.getBuildings()
    researchStationIsBuild = False
    totalUsePower = 0
    maxPower = 10000000000
    for building in reserchStationBuildings:
        if(building.getCategory() == "Research"):
            print(building)
            totalUsePower += building.getUsePower()
        if(building.getCategory() == "Wire"):
            if(building.getMaxPower()*1000 < maxPower):
                maxPower = building.getMaxPower()*1000
    if(totalUsePower<maxPower):
        researchStation.build()
        researchStationIsBuild = True
    else:
        print("Power Overload.")
        
    print("\ntotalUsePower: " + str(totalUsePower) + ", maxPower " + str(maxPower))
    
    print()
    powerStation.destroy()
    if researchStationIsBuild:
        researchStation.destroy()

if __name__=="__main__":
    main()