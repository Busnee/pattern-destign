public class Program {
    interface PaintingHandler{
        public abstract void setNext(PaintingHandler p);
        public abstract void handle(String request);
    }
    public static class Painting implements PaintingHandler{
        private PaintingHandler nextHandler;
        private Painting(){
            nextHandler = null;
        }
        public void setNext(PaintingHandler p){
            nextHandler = p;
        }
        public void handle(String request){
            if(nextHandler != null){
                nextHandler.handle(request);
            }
        }
    }
    public static class Sketch extends Painting{
        public Sketch(){
            super();
        }
        public void handle(String request){
            System.out.println(request + ": sketch");
            super.handle(request);
        }
    }
    public static class Inking extends Painting{
        public Inking(){
            super();
        }
        public void handle(String request){
            if(request.toLowerCase() != "overpainting"){
                System.out.println(request + ": inking");
            }
            super.handle(request);
        }
    }
    public static class Coloring extends Painting{
        public Coloring(){
            super();
        }
        public void handle(String request){
            if(request.toLowerCase() != "lineart only"){
                System.out.println(request + ": coloring");
            }
            super.handle(request);
        }
    }
    public static class LightingShading extends Painting{
        public LightingShading(){
            super();
        }
        public void handle(String request){
            if(request.toLowerCase() != "lineart only"){
                System.out.println(request + ": lighting and shading");
            }
            super.handle(request);
        }
    }
    public static class ColoringLineart extends Painting{
        public ColoringLineart(){
            super();
        }
        public void handle(String request){
            if(request.toLowerCase() == "colored lineart"){
                System.out.println(request + ": coloring lineart");
            }
            super.handle(request);
        }
    }
    public static void main(String[] args) {
        Sketch sketch = new Sketch();
        Inking inking = new Inking();
        Coloring coloring = new Coloring();
        LightingShading lightingShading = new LightingShading();
        ColoringLineart coloringLineart = new ColoringLineart();

        sketch.setNext(inking);
        inking.setNext(coloring);
        coloring.setNext(lightingShading);
        lightingShading.setNext(coloringLineart);

        Sketch s1 = new Sketch();
        Coloring c1 = new Coloring();
        LightingShading l1 = new LightingShading();

        s1.setNext(c1);
        c1.setNext(l1);

        sketch.handle("Painting");
        System.out.println();

        inking.handle("lineart only");
        System.out.println();

        coloring.handle("overpainting");
        System.out.println();
        
        sketch.handle("colored lineart");
        System.out.println();

        s1.handle("overpainting");
    }
}