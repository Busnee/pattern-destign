// interface
class IPlant{
    constructor(){
        if(this.constructor == IPlant){
            throw new Error("IPlant class is Interface.")
        }
        if(this.water == undefined){
            throw new Error("water method must be implemented.")
        }
        if(this.fertilize == undefined){
            throw new Error("fertilize method must be implemented.")
        }
        if(this.harvest == undefined){
            throw new Error("harvest method must be implemented.")
        }
    }
}

class Plant extends IPlant{
    static READY_TO_HARVEST_STATUS = "ready to harvest"
    static GROWING_STATUS = "growing"
    static PLUS_WATER_PERCENT = 20
    static PLUS_FERTILIZE_PERCENT = 10
    constructor(){
        super()
        this.status = Plant.GROWING_STATUS
        this.growthPercent = 0
    }
    water(){
        if(this.status == Plant.READY_TO_HARVEST_STATUS){
            return false
        }
        this.growthPercent += Plant.PLUS_WATER_PERCENT
        if(this.growthPercent >= 100){
            this.status = Plant.READY_TO_HARVEST_STATUS
            this.growthPercent = 100
        }
        console.log("water the plant")
        return true
    }
    fertilize(){
        if(this.status == Plant.READY_TO_HARVEST_STATUS){
            return false
        }
        this.growthPercent += Plant.PLUS_FERTILIZE_PERCENT
        if(this.growthPercent >= 100){
            this.status = Plant.READY_TO_HARVEST_STATUS
            this.growthPercent = 100
        }
        console.log("fertilize the plant")
        return true
    }
    harvest(){
        if(this.status == Plant.GROWING_STATUS){
            return false
        }
        this.status = Plant.GROWING_STATUS
        this.growthPercent = 0
        console.log("harvest the plant")
        return true
    }
    getStatus(){
        return this.status
    }
    getGrowthPercent(){
        return this.growthPercent
    }
    setGrowthPercent(percent){
        this.growthPercent = percent
    }
}
class PlantProxy extends IPlant{
    constructor(realPlant){
        super()
        this.realPlant = realPlant
        this.growthPercent = this.realPlant.getGrowthPercent()
        console.log(this.realPlant)
    }
    water(){
        console.log("proxy: water the plant.")
        if(this.growthPercent+Plant.PLUS_WATER_PERCENT < 100 ){
            this.growthPercent += Plant.PLUS_WATER_PERCENT
            return true
        }
        this.realPlant.setGrowthPercent(this.growthPercent)
        const result = this.realPlant.water()
        this.growthPercent = this.realPlant.getGrowthPercent()
        return result
    }
    fertilize(){
        console.log("proxy: fertilize the plant.")
        if(this.growthPercent+Plant.PLUS_WATER_PERCENT < 100){
            this.growthPercent += Plant.PLUS_FERTILIZE_PERCENT
            return true
        }
        this.realPlant.growthPercent = this.growthPercent
        const result = this.realPlant.fertilize()
        this.growthPercent = this.realPlant.getGrowthPercent()
        return result
    }
    harvest(){
        console.log("proxy: harvest the plant.")
        if(this.growthPercent < 100){
            return false
        }
        const result = this.realPlant.harvest()
        this.growthPercent = this.realPlant.getGrowthPercent()
        return result
    }
}

p = new Plant();
pproxy = new PlantProxy(p);
console.log(p.getStatus(),p.getGrowthPercent())
console.log(pproxy.water(),pproxy.growthPercent)
console.log(pproxy.water(),pproxy.growthPercent)
console.log(pproxy.harvest(),pproxy.growthPercent,"\n")

console.log(pproxy.water(),pproxy.growthPercent)
console.log(pproxy.water(),pproxy.growthPercent)
console.log(pproxy.water(),pproxy.growthPercent)
console.log(pproxy.water(),pproxy.growthPercent)
console.log(pproxy.harvest(),pproxy.growthPercent,"\n")

console.log(pproxy.water(),pproxy.growthPercent)
console.log(pproxy.water(),pproxy.fertilize(),pproxy.harvest(),pproxy.growthPercent,"\n")