class ElmentInfo{
    constructor(name, state, specificHeatCapacity, thermalConductivity, lightAbsorption){
        this.name = name;
        this.state = state;
        this.specificHeatCapacity = specificHeatCapacity;
        this.thermalConductivity = thermalConductivity;
        this.lightAbsorption = lightAbsorption;
    }
    updateDialog(div, x, y, capacity, temperature){
        let name = this.name;
        let specificHeatCapacity = this.specificHeatCapacity;
        let thermalConductivity = this.thermalConductivity;
        let lightAbsorption = this.lightAbsorption;

        let divOnclickId = `x${x}y${y}`;

        div.on("click", function(){
            if (divOnclickId == $("#dialogElmId").text() && $("#dialog").is(":visible")){
                $("#dialog").hide()
            }else{
                $("#dialogElmId").text(divOnclickId);
                $("#elmName").html(`${name}`);
                $("#elmPosition").html(`<span style="color: gray;"}>x: </span>${y}<span style="color: gray;"> y:</span>${x}`);
                if(this.state == "gas"){
                    $("#elmCapacity").html(`${capacity} g`);
                }else{
                    $("#elmCapacity").html(`${capacity} kg`);
                }
                $("#elmTemperature").html(`${temperature} °C`);
                $("#elmSpecificHeatCapacity").html(`${specificHeatCapacity} (DTU/g)/°C`);
                $("#elmThermalConductivity").html(`${thermalConductivity} (DTU/(m*s))/°C`);
                $("#elmLightAbsorption").html(`${lightAbsorption*100} %`);
                $("#dialog").show()
            }        
        })
    }
    getName(){
        return this.name;
    }
    getState(){
        return this.state;
    }
    getSpecificHeatCapacity(){
        return this.specificHeatCapacity;
    }
    getThermalConductivity(){
        return this.thermalConductivity;
    }
    getLightAbsoption(){
        return this.lightAbsorption;
    }
}

class ElementInfoFactory{
    constructor(){
        this.elementInfo = [];
    }
    getElementInfo(name, state, specificHeatCapacity, thermalConductivity, lightAbsorption){
        for(let item of this.elementInfo){
            if(item.getName() == name && item.getState() == state 
            && item.getSpecificHeatCapacity() == specificHeatCapacity
            && item.getThermalConductivity() == thermalConductivity 
            && item.getLightAbsoption() == lightAbsorption)
            {
                return item;
            }
        }
        var newElementInfo = new ElmentInfo(name, state, specificHeatCapacity, thermalConductivity, lightAbsorption);
        this.elementInfo.push(newElementInfo);
        return newElementInfo;
    }
}

class Element{
    constructor(x, y, capacity, temperature, elementInfo){
        this.x = x;
        this.y = y;
        this.capacity = capacity;
        this.temperature = temperature;
        this.elementInfo = elementInfo;
    }
    setElementInfo(elementInfo){
        this.elementInfo = elementInfo;
    }
    getElementInfo(){
        return this.elementInfo
    }
    updateDialog(div){
        this.elementInfo.updateDialog(div, this.x, this.y, this.capacity, this.temperature)
    }
}


class Map{
    constructor(xMax, yMax){
        this.xMax = xMax;
        this.yMax = yMax;
        this.element = [];

        for(let x=0; x<xMax; x++){
            this.element[x] = [];
            for(let y=0; y<yMax; y++){
                this.element[x][y] = {x,y}
            }
        }
        console.log(this.element)
    }
    setElement(x, y, name, capacity, temperature, state, specificHeatCapacity, thermalConductivity, lightAbsorption, elementInfoFactory){
        let elementInfo = elementInfoFactory.getElementInfo(name, state, specificHeatCapacity, thermalConductivity,lightAbsorption);
        this.element[x][y] = new Element(x, y, capacity, temperature, elementInfo);
    }
    generateMap(){
        console.log(this.element)
        let tableMap = $("#Map");

        let col = [];
        for(let x=0; x<this.xMax; x++){
            col[x] = [];
            for(let y=0; y<this.yMax; y++){
                col[x][y] = {x,y}
            }
        }

        for(let x=0; x<this.xMax; x++){
            for(let y=0; y<this.yMax; y++){
                let td = $("<td/>");
                let div = $("<div/>", {class: `Element, ${this.element[x][y].getElementInfo().getName()}`});
                div.css("opacity", this.element[x][y].getElementInfo().getLightAbsoption())
                let id = `x${x}y${y}`;
                div.attr("id", id);
                this.element[x][y].updateDialog(div);
                td.append(div);
                col[x][y] = td;
            }
        }

        for(let x=0; x<this.xMax; x++){
            let tr = $("<tr/>");
            for(let y=0; y<this.yMax; y++){
                tr.append(col[x][y])
            }
            tableMap.append(tr);
        }
    }
}

