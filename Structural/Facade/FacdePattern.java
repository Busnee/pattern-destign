import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class FacdePattern {
    public static DateTimeFormatter dateTimeFormatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");

    public static class Beverage{
        public void brewCoffe(){
            System.out.println("brew Coffe");
        }
        public void brewThaiTea(){
            System.out.println("brew Thai Tea");
        }
        public void brewMatcha(){
            System.out.println("brew Matcha");
        }
    }
    public static class ProductLabel{
        String name;
        LocalDate mfg;
        LocalDate exp;
        public ProductLabel(){
            this.name = "";
            this.mfg = this.exp = LocalDate.now();
        }
        public void makeLabel(){
            System.out.println("make label of "+ this.name);
        }
        public void setName(String n){
            this.name = n;
        }
        public void setMFG(LocalDate date){
            this.mfg = date;
        }
        public void setEXP(LocalDate date){
            this.exp = date;
        }
        public String getName(){
            return this.name;
        }
        public LocalDate getMFG(){
            return this.mfg;
        }
        public LocalDate getEXP(){
            return this.exp;
        }
    }
    public static class Container{
        String containerType;
        public Container(){
            this.containerType = "can";
        }
        public void setType(String t){
            this.containerType = t;
        }
        public void fillIce(){
            System.out.println("fill Ice to " + containerType);
        }
        public void fillWater(){
            System.out.println("fill water to " + containerType);
        }
        public void fillMilk(){
            System.out.println("fill milk to " + containerType);
        }
        public void fillBeverage(String beverageType){
            System.out.println("fill "+ beverageType + " to " + containerType);
        }
        public void seal(){
            System.out.println("seal " + containerType);
        }
        public void labeling(ProductLabel label){
            System.out.println("lablling " + containerType);
            System.out.println("--------------------------");
            System.out.println("\t" + label.getName());
            System.out.println("\tMFG : " + label.getMFG().format(dateTimeFormatter));
            System.out.println("\tEXP : " + label.getEXP().format(dateTimeFormatter));
            System.out.println("--------------------------");
        }
    }

    // can use LocalDate.pulsDays method
    public static LocalDate increaseDate(LocalDate date, int numberOfDay){
        int d = date.getDayOfMonth();
        int m = date.getMonthValue();
        int y = date.getYear();
        int temp = numberOfDay;

        while (temp > 0) {
            switch (m) {
                case 2:
                    if( y % 4 == 0){
                        if (d+temp <= 29){
                            d += temp;
                            temp = 0;
                            break;
                        }else {
                            int t = 29 - d;
                            d = 0;
                            temp -= t;
                            m++;
                            continue;
                        }
                    }else {
                        if (d+temp <= 28){
                            d += temp;
                            temp = 0;
                            break;
                        }else {
                            int t = 28 - d;
                            d = 0;
                            temp -= t;
                            m++;
                            continue;
                        }
                    }                    
                case 4, 6, 9, 11:
                    if (d+temp <= 30){
                        d += temp;
                        temp = 0;
                        break;
                    }else {
                        int t = 30 - d;
                        d = 0;
                        temp -= t;
                        m++;
                        continue;
                    }
                case 1, 3, 5, 7, 8, 10:
                    if (d+temp <= 31){
                        d += temp;
                        temp = 0;
                        break;
                    }else {
                        int t = 31 - d;
                        d = 0;
                        temp -= t;
                        m++;
                        continue;
                    }
                case 12:
                    if (d+temp < 31){
                        d += temp;
                        temp = 0;
                        break;
                    }else {
                        int t = 31 - d;
                        d = 0;
                        temp -= t;
                        m = 1;
                        y++;
                        continue;
                    }
                default:
                    temp = -1;
                    break;
            }
        }
        LocalDate result = LocalDate.of(y, m, d);
        return result;
    }
    public static class BverageProductFacade{
        Beverage beverage;
        Container container;
        ProductLabel productLabel;
        public BverageProductFacade(){
            beverage = new Beverage();
            container = new Container();
            productLabel = new ProductLabel();
        }
        public void makeBeverageProduct(String beverageName, String containerType, boolean iced){
            String beverageType = "";
            if(beverageName == "americano" || beverageName == "latte"){
                this.beverage.brewCoffe();
                beverageType = "coffe";
            } else if(beverageName == "thai tea"){
                this.beverage.brewThaiTea();
                beverageType = "thai tea";
            } else if(beverageName == "matcha"){
                this.beverage.brewMatcha();
                beverageType = "matcha";
            }

            this.container.setType(containerType);
            LocalDate nowDate = LocalDate.now();
            this.productLabel.setMFG(nowDate);
            if(containerType == "can"){
                this.productLabel.setEXP(increaseDate(nowDate, 7));
            } else if(containerType == "bottle"){
                this.productLabel.setEXP(increaseDate(nowDate, 3));
            } else if(containerType == "cup"){
                this.productLabel.setEXP(increaseDate(nowDate, 1));
            }

            if(iced){
                this.productLabel.setName("Iced " + beverageName);
                this.container.fillIce();
            } else {
                this.productLabel.setName(beverageName);
            }

            this.container.fillBeverage(beverageType);
            if(beverageName == "americano"){
                this.container.fillWater();
            } else if( beverageName == "latte" 
                    || beverageName == "thai tea" 
                    || beverageName == "matcha latte"){
                this.container.fillMilk();
            }            
            this.container.seal();

            this.productLabel.makeLabel();
            this.container.labeling(productLabel);
        }
    }
    public static void main(String[] args){
        BverageProductFacade b = new BverageProductFacade();

        System.out.println("...Make Ice Americano...");
        b.makeBeverageProduct("americano", "can", true);
        System.out.println("...Make Latte...");
        b.makeBeverageProduct("latte", "cup", false);
        System.out.println("...Make Ice Thai Tea...");
        b.makeBeverageProduct("thai tea", "can", true);
        System.out.println("...Make Matcha Latte...");
        b.makeBeverageProduct("matcha latte", "bottle", false);

        return ;
    }
}