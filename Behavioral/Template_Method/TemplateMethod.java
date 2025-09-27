public class TemplateMethod {
    public static abstract class PlantedFlower {
        public void preProcess() { }
        public abstract void digHole();
        public abstract void putIntoHole();
        public void coverByDirt(){
            System.out.println("cover the plant by dirt.");
        }
        public void water(){
            System.out.println("water the plant.");
        }
        public void plant(){
            preProcess();
            digHole();
            putIntoHole();
            coverByDirt();
            water();
        }
    }
    public static class Rose extends PlantedFlower {
        String color;
        public Rose(){
            this.color = "red";
        }
        public Rose(String color){
            this.color = color;
        }
        public void preProcess() { 
            System.out.println("level the ground.");
        }
        public void digHole(){
            System.out.println("dig hole 15 cm.");
        }
        public void putIntoHole(){
            System.out.println("put " + color + " rose graft into the hole.");
        }
    }
    public static class Marigold extends PlantedFlower {
        public void digHole(){
            System.out.println("dig hole 10 cm.");
        }
        public void putIntoHole(){
            System.out.println("put marigold seed into the hole.");
        }
        public void coverByDirt(){
            System.out.println("cover the plant by dirt lightly.");
        }
    }
    public static void main(String[] args) {
        Rose yellowRose = new Rose("yellow");
        Rose rose = new Rose();
        Marigold marigold = new Marigold();

        System.out.println("-Yellow Rose-");
        yellowRose.plant();
        System.out.println();

        System.out.println("-Rose-");
        rose.plant();
        System.out.println();
        
        System.out.println("-Marigold-");
        marigold.plant();
        System.out.println();
    }
    
}