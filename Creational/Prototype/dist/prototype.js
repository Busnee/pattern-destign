"use strict";
// const readline = require("readline-sync");
// let input = readline.createInterface(
// 		process.stdin, process.stdout
// );
class MusicalInstrument {
    constructor(id, model, type, color) {
        this.id = id;
        this.model = model;
        this.type = type;
        this.color = color;
    }
    getID() {
        return this.id;
    }
    play() {
        return "Instrument: " + this.id + ", " + this.type + " is playing...";
    }
    getDetail() {
        let detail = "";
        detail += "ID: " + this.id;
        detail += "\nModel: " + this.model;
        detail += "\nType: " + this.type;
        detail += "\nColor: " + this.color;
        return detail;
    }
}
class Guitar extends MusicalInstrument {
    constructor(id, model, type, color, numOfString, stringMaterial, pickup) {
        super(id, model, type, color);
        this.numOfString = numOfString;
        this.stringMaterial = stringMaterial;
        this.pickup = pickup;
    }
    clone() {
        return new Guitar(this.id, this.model, this.type, this.color, this.numOfString, this.stringMaterial, this.pickup);
    }
    getDetail() {
        let detail = super.getDetail();
        detail += "\nNumber of string:" + this.numOfString;
        detail += "\nString Material:" + this.stringMaterial;
        detail += "\nPickup:" + this.pickup;
        return detail;
    }
}
class Keyboard extends MusicalInstrument {
    constructor(id, model, type, color, numOfKey, canRecord, haveDisplayScreen) {
        super(id, model, type, color);
        this.numOfKey = numOfKey;
        this.canRecord = canRecord;
        this.haveDisplayScreen = haveDisplayScreen;
    }
    clone() {
        return new Keyboard(this.id, this.model, this.type, this.color, this.numOfKey, this.canRecord, this.haveDisplayScreen);
    }
    getDetail() {
        let detail = super.getDetail();
        detail += "\nNumber of key:" + this.numOfKey;
        if (this.canRecord) {
            detail += "\nRecording: can recording";
        }
        else {
            detail += "\nRecording: can not recording";
        }
        if (this.haveDisplayScreen) {
            detail += "\nDisplay screen: have";
        }
        else {
            detail += "\nDisplay screen: none";
        }
        return detail;
    }
}
class Violin extends MusicalInstrument {
    constructor(id, model, type, color, numOfString, stringMaterial) {
        super(id, model, type, color);
        this.numOfString = numOfString;
        this.stringMaterial = stringMaterial;
    }
    clone() {
        return new Violin(this.id, this.model, this.type, this.color, this.numOfString, this.stringMaterial);
    }
    getDetail() {
        let detail = super.getDetail();
        detail += "\nNumber of string:" + this.numOfString;
        detail += "\nString material:" + this.stringMaterial;
        return detail;
    }
}
class MusicalInstrumentRegistry {
    constructor() {
        this.instuments = [];
        this.instuments.push(new Guitar(0, 'Fender CD-60S', 'Acoustic Guitar', 'Natural', 6, 'Coated', 'none'));
        this.instuments.push(new Guitar(1, 'Jackson Soloist SLX', 'Electric Guitar', 'Rocket Red', 6, 'Steel', '2 Humbuckers'));
        this.instuments.push(new Keyboard(2, 'Yamaha CP88', 'Piano Keyboard', 'black', 88, true, false));
        this.instuments.push(new Violin(3, 'Overtone OV-600', 'Classical Violin', 'Natural Wood', 4, 'Steel'));
    }
    createInstrument(id) {
        for (let i = 0; i < this.instuments.length; i++) {
            if (this.instuments[i].getID() === id) {
                return this.instuments[i].clone();
            }
        }
        return this.instuments[0];
    }
}
function Client() {
    const registry = new MusicalInstrumentRegistry();
    console.log("---Show Musical instrument registry---");
    for (let i = 0; i < registry.instuments.length; i++) {
        const detail = registry.instuments[i].getDetail();
        console.log(detail, '\n');
    }
    const inventory = [];
    inventory[0] = registry.createInstrument(0);
    inventory[1] = registry.createInstrument(2);
    console.log("---Show inventory---");
    for (let i = 0; i < inventory.length; i++) {
        console.log(inventory[i].getDetail(), '\n');
    }
    console.log("---Play instrument in inventory---");
    for (let i = 0; i < inventory.length; i++) {
        console.log(inventory[i].play());
    }
}
Client();
process.exit(0);
