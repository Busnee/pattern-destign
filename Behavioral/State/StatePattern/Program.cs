using System;

namespace StatePattern
{
    class Human
    {
        private string name;
        private State state;

        public string Name { get { return name; } set { name = value; }}
        public Human(string name, State state)
        {
            this.name = name;
            this.state = state;
            this.state.setHuman(this);
        }
        public void changeState(State s)
        {
            this.state = s;
            s.setHuman(this);
        }
        public void inTheRain()
        {
            state.inTheRain();
        }
        public void sleepDeprived36H()
        {
            state.sleepDeprived36H();
        }
        public void bittenByMosquito(bool haveDengueVirus)
        {
            state.bittenByMosquito(haveDengueVirus);
        }
        public void takeMedicine(string medicineName)
        {
            state.takeMedicine(medicineName);
        }
        public void beTreated()
        {
            state.beTreated();
        }
    }
    abstract class State
    {
        protected Human human;
        public void setHuman(Human h)
        {
            this.human = h;
        }
        abstract public void inTheRain();
        abstract public void sleepDeprived36H();
        abstract public void bittenByMosquito(bool haveDengueVirus);
        abstract public void takeMedicine(string medicineName);
        abstract public void beTreated();
    }
    class Fine : State
    {
        public override void inTheRain()
        {
            human.changeState(new HaveFever());
            Console.WriteLine(human.Name + " have Fever");
        }
        public override void sleepDeprived36H()
        {
            human.changeState(new HaveFever());
            Console.WriteLine(human.Name + " have Fever");
        }
        public override void bittenByMosquito(bool haveDengueVirus)
        {
            if (haveDengueVirus) {
                human.changeState(new HaveDengueFever());
                Console.WriteLine(human.Name + " have Dengue Fever");
            }
        }
        public override void takeMedicine(string medicineName)
        {
            Console.WriteLine(human.Name + " is Fine");
        }
        public override void beTreated()
        {
            Console.WriteLine(human.Name + " is Fine");
        }
    }
    class HaveFever : State
    {
        public override void inTheRain()
        {
            Console.WriteLine(human.Name + " have Fever");
        }
        public override void sleepDeprived36H()
        {
            Console.WriteLine(human.Name + " have Fever");
        }
        public override void bittenByMosquito(bool haveDengueVirus)
        {
            if (haveDengueVirus)
            {
                human.changeState(new HaveDengueFever());
                Console.WriteLine(human.Name + " have Dengue Fever");
            }
        }
        public override void takeMedicine(string medicineName)
        {
            if (medicineName == "Paracetamol")
            {
                human.changeState(new Fine());
                Console.WriteLine(human.Name + " is Fine");
            }
        }
        public override void beTreated()
        {
            human.changeState(new Fine());
            Console.WriteLine(human.Name + " is Fine");
        }
    }
    class HaveDengueFever : State
    {
        public override void inTheRain()
        {
            Console.WriteLine(human.Name + " have Dengue Fever");
        }
        public override void sleepDeprived36H()
        {
            Console.WriteLine(human.Name + " have Dengue Fever");
        }
        public override void bittenByMosquito(bool haveDengueVirus)
        {
            Console.WriteLine(human.Name + " have Dengue Fever");
        }
        public override void takeMedicine(string medicineName)
        {
            Console.WriteLine(human.Name + " have Dengue Fever");
        }
        public override void beTreated()
        {
            human.changeState(new Fine());
            Console.WriteLine(human.Name + " is Fine");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human plaWhale = new Human("Pla Whale", new Fine());
            plaWhale.beTreated();
            plaWhale.bittenByMosquito(true);
            plaWhale.beTreated();
            plaWhale.inTheRain();
            plaWhale.bittenByMosquito(false);
            plaWhale.takeMedicine("Paracetamol");
            plaWhale.bittenByMosquito(false);
        }
    }
}