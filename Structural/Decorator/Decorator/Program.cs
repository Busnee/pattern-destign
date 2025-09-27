using System;

namespace DecoratorPattern
{
    public interface Dish
    {
        public string getName();
        public int getSodium();
    }
    class Rice : Dish
    {
        string riceType;
        int sodium;
        public Rice(string riceType, int sodium) {
            this.riceType = riceType;
            this.sodium = sodium;
        }
        public string getName()
        {
            return this.riceType;
        }
        public int getSodium()
        {
            return this.sodium;
        }   
    }
    class FriedChicken : Dish
    {
        Dish dish;
        public FriedChicken(Dish d)
        {
            this.dish = d;
        }
        public string getName()
        {
            return dish.getName() + ", Fried chicken";
        }
        public int getSodium()
        {
            return dish.getSodium() + 450;
        }   
    }
    class PapayaSalad : Dish
    {
        Dish dish;
        public PapayaSalad(Dish d)
        {
            this.dish = d;
        }
        public string getName()
        {
            return dish.getName() + ", Papaya salad";
        }
        public int getSodium()
        {
            return dish.getSodium() + 1800;
        }   
    }
    class KaengSom : Dish
    {
        Dish dish;
        public KaengSom(Dish d)
        {
            this.dish = d;
        }
        public string getName()
        {
            return dish.getName() + ", Kaeng som";
        }
        public int getSodium()
        {
            return dish.getSodium() + 1100;
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rice riceBerry = new Rice("Riceberry", 2);
            Rice jusmineRice = new Rice("Jusmine rice", 10);

            PapayaSalad jusmineRice_papayaSalad = new PapayaSalad(jusmineRice);
            KaengSom riceBerry_kaengSom = new KaengSom(riceBerry);

            FriedChicken dish1 = new FriedChicken(jusmineRice_papayaSalad);
            FriedChicken dish2 = new FriedChicken(riceBerry_kaengSom);

            Console.WriteLine("dish1 have sodium " + dish1.getSodium() + " consists of " + dish1.getName());
            Console.WriteLine("dish2 have sodium " + dish2.getSodium() + " consists of " + dish2.getName());
            Console.WriteLine();

            int sodiumCompare = dish1.getSodium() - dish2.getSodium();
            if (sodiumCompare > 0)
            {
                Console.WriteLine("dish1 have sodium more than dish2 equal to " + sodiumCompare);
            }
            else if (sodiumCompare < 0)
            {
                Console.WriteLine("dish2 have sodium more than dish1 equal to " + sodiumCompare/-1);
            }
            else
            {
                Console.WriteLine("dish1 have sodium equal to dish2");
            }
        }
    }
}