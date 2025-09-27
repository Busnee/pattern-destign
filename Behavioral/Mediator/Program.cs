using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Order
    {
        private int id;
        private string name;
        static int lastID = 0;

        public int ID { get { return id; } }
        public string Name { get { return name; } }

        public Order(string name) { 
            this.name = name;
            this.id = lastID++;
        }

    }
    class RestaurantComponent
    {
        protected RestaurantMediator? mediator;
        private bool idle;

        public bool IsIdle { get { return idle; } set { idle = value; } }

        public RestaurantComponent()
        {
            mediator = null;
            this.idle = true;
        }
        public void setMediator(RestaurantMediator mediator)
        {
            this.mediator = mediator;
        }
    }
    class Waiter: RestaurantComponent
    {
        private string name;
        private char gender;

        public string Name { get { return name; } set { name = value; } }
        public char Gender { get { return gender; } set { gender = value; } }
        public Waiter(string name, char gender)
        {
            this.name = name;
            this.gender = gender;
        }
        public string getCareerName()
        {
            if(this.gender == 'f')
            {
                return "Waitress";
            }
            else
            {
                return "Waiter";
            }
        }
        public void takeOrder(string orderName, int num)
        {
            this.IsIdle = false;
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(1000 * num);
                Console.WriteLine(getCareerName() + ": " + this.name + " take order \"" + orderName + "\" x" + num);
                this.IsIdle = true;
                for (int i = 0; i < num; i++)
                {
                    mediator?.notify(this, "take order", new Order(orderName));
                }             
            });

            thread.Start();
        }
        public void serve(Order order)
        {
            this.IsIdle = false;
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine(getCareerName() + ": " + this.name + " serve " + order.Name);
                this.IsIdle = true;
                mediator?.notify(this, "idle", null);        
            });

            thread.Start();
        }
    }
    class Chef: RestaurantComponent
    {
        private string name;

        public string Name { get { return name;} set { name = value; } }

        public Chef(string name)
        {
            this.name = name;
        }
        public void cook(CookingEquipment equipment)
        {
            this.IsIdle = false;
            Thread thread = new Thread(() =>
            {
                Order order = equipment.cook(this);
                equipment.Thread?.Join();
                Console.WriteLine("Chef: " + Name + " has finished cooking " + order.Name);
                this.IsIdle = true;
                mediator?.notify(this, "finish cooking", order);                
            });

            thread.Start();
        }
    }
    abstract class CookingEquipment: RestaurantComponent
    {
        protected Thread? thread;
        public Thread? Thread { get { return thread; } }
        public abstract Order cook(Chef chef);

    }
    class Grill: CookingEquipment   // เตาปื้ง-ย่าง
    {
        static List<Order> queue = new List<Order>();
        private int id;

        public int ID { get { return id; } }
        static public bool haveQueue { get {  return queue.Count > 0; } }
        public Grill(int id)
        {
            this.id = id;
        }
        static public void addQueue(Order order)
        {
            queue.Add(order);
        }
        public Order removeQueue()
        {
            Order order = queue[0];
            queue.RemoveAt(0);

            return order;
        }
        public override Order cook(Chef chef)
        {
            this.IsIdle = false;
            Order order = removeQueue();

            this.thread = new Thread(() =>
            {
                Console.WriteLine("Grill" + ID + " : Chef " + chef.Name + " is cooking " + order.Name);
                if(order.Name == "KaiYang")
                {
                    Thread.Sleep(1000); 
                }
                else
                {
                    Thread.Sleep(500);
                }
                this.IsIdle = true;
                mediator?.notify(this, "idle", null);
            });
            
            thread.Start();
            return order;
        }
    }
    class Mortar: CookingEquipment  // ครก
    {
        static List<Order> queue = new List<Order>();
        private int id;

        public int ID { get { return id; } }
        static public bool haveQueue { get { return queue.Count > 0; } }

        public Mortar(int id)
        {
            this.id = id;
        }
        static public void addQueue(Order order)
        {
            queue.Add(order);
        }
        public Order removeQueue()
        {
            Order order = queue[0];
            queue.RemoveAt(0);

            return order;
        }
        public override Order cook(Chef chef)
        {
            this.IsIdle = false;
            Order order = removeQueue();

            this.thread = new Thread(() =>
            {
                Console.WriteLine("Mortar" + ID + ": Chef " + chef.Name + " is cooking " + order.Name);
                Thread.Sleep(5000);
                this.IsIdle = true;
                mediator?.notify(this, "idle", null);
            });

            thread.Start();

            return order;
        }
    }
    interface RestaurantMediator
    {
        public void notify(RestaurantComponent sender, string evnt, Order order);
    }
    class SomtamRestaurantMediator: RestaurantMediator
    {
        private List<Waiter> waiters;
        private List<Chef> chefs;
        private List<Grill> grills;
        private List<Mortar> mortars;
        private List<Order> orders;
        private List<Order> serveQueue;

        private Thread thread;

        public SomtamRestaurantMediator()
        {
            waiters = new List<Waiter>();
            chefs = new List<Chef>();
            grills = new List<Grill>();
            mortars = new List<Mortar>();
            orders = new List<Order>();
            serveQueue = new List<Order>();
        }
        public void notify(RestaurantComponent sender, string evnt, Order? order)
        {
            if (sender.GetType().Name == "Waiter" && evnt == "take order")
            {
                orders.Add(order);
                string orderName = order.Name;
                if (orderName == "KaiYang" || orderName == "PlaDukYang")
                {
                    Grill.addQueue(order);
                    Grill? idleGrill = getIdleGrill();
                    Chef? idleChef = getIdleChef();
                    if (idleGrill != null && idleChef != null)
                    {
                        idleChef.cook(idleGrill);
                    }
                    else
                    {
                        setNotIdle(idleGrill);
                        setNotIdle(idleChef);
                    }
                }
                else if (orderName == "SomTamThai" || orderName == "SomTamPu")
                {
                    Mortar.addQueue(order);
                    Mortar? idleMortar = getIdleMortar();
                    Chef? idleChef = getIdleChef();
                    if (idleMortar != null && idleChef != null)
                    {
                        idleChef.cook(idleMortar);
                    }
                }
            }
            else if (sender.GetType().Name == "Waiter" && evnt == "idle")
            {
                if (serveQueue.Count > 0)
                {
                    getIdleWaiter()?.serve(removeServeQueue());
                }
            }
            else if (sender.GetType().Name == "Chef" && evnt == "finish cooking")
            {
                addSevreQueue(removeOrder(order.ID));
                Waiter? idleWaiter = getIdleWaiter();
                Order? serveOrder = removeServeQueue();
                if (idleWaiter != null && serveOrder != null)
                {
                    idleWaiter.serve(serveOrder);
                }
            }
            else if (sender.GetType().Name == "Grill" && evnt == "idle" && Grill.haveQueue)
            {
                Grill? idleGrill = getIdleGrill();
                Chef? idleChef = getIdleChef();
                if (idleGrill != null && idleChef != null)
                {
                    idleChef.cook(idleGrill);
                }
            }
            else if (sender.GetType().Name == "Mortar" && evnt == "idle" && Mortar.haveQueue)
            {
                Mortar? idleMortar = getIdleMortar();
                Chef? idleChef = getIdleChef();
                if (idleMortar != null && idleChef != null)
                {
                    idleChef.cook(idleMortar);
                }
            }
        }
        public void handleTask()
        {
            thread = new Thread(() =>
            {
                while (true)
                {
                    if (Grill.haveQueue)
                    {
                        Grill? idleGrill = getIdleGrill();
                        Chef? idleChef = getIdleChef();
                        if (idleGrill != null && idleChef != null)
                        {
                            idleChef.cook(idleGrill);
                        }
                    }
                    else if (Mortar.haveQueue)
                    {
                        Mortar? idleMortar = getIdleMortar();
                        Chef? idleChef = getIdleChef();
                        if (idleMortar != null && idleChef != null)
                        {
                            idleChef.cook(idleMortar);
                        }
                    }
                    else if (serveQueue.Count > 0)
                    {
                        Waiter? idleWaiter = getIdleWaiter();
                        Console.Write(1);
                        if (idleWaiter != null)
                        {
                            idleWaiter.serve(removeServeQueue());
                        }
                    }
                    Thread.Sleep(1000);
                }
            });

            thread.Start();
        }
        public void addWaiter(Waiter waiter)
        {
            waiter.setMediator(this);
            waiters.Add(waiter);
        }
        public void addChef(Chef chef) {
            chef.setMediator(this);
            chefs.Add(chef);
        }
        public void addGrill(Grill grill)
        {
            grill.setMediator(this);
            grills.Add(grill);
        }
        public void addMortar(Mortar mortar)
        {
            mortar.setMediator(this);
            mortars.Add(mortar);
        }
        public void addOrder(Order order)
        {
            orders.Add(order);
        }
        public void addSevreQueue(Order order)
        {
            serveQueue.Add(order);
        }
        public Order? removeOrder(int orderId)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].ID == orderId)
                {
                    Order order = orders[i];
                    orders.RemoveAt(i);
                    return order;
                }
            }
            return null;
        }
        public Order? removeServeQueue()
        {
            lock (serveQueue){
                if (serveQueue.Count > 0)
                {
                    Order order = serveQueue[0];
                    serveQueue.RemoveAt(0);
                    return order;
                }            
            }
            return null;
        }
        public Waiter? getIdleWaiter()
        {
            foreach(Waiter waiter in waiters)
            {
                if (waiter.IsIdle)
                {
                    // waiter.IsIdle = false;
                    return waiter;
                }
            }
            return null;
        }
        public Chef? getIdleChef()
        {
            foreach(Chef chef in chefs)
            {
                if (chef.IsIdle)
                {
                    // chef.IsIdle = false;
                    return chef;
                }
            }
            return null;
        }
        public Grill? getIdleGrill()
        {
            foreach (Grill grill in grills)
            {
                if (grill.IsIdle)
                {
                    // grill.IsIdle = false;
                    return grill;
                }
            }
            return null;
        }
        public Mortar? getIdleMortar()
        {
            foreach(Mortar mortar in mortars)
            {
                if(mortar.IsIdle)
                {
                    // mortar.IsIdle = false;
                    return mortar;
                }
            }
            return null;
        }
        public void setNotIdle(RestaurantComponent? r)
        {
            if(r != null)
            {
                r.IsIdle = false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiterSabastian = new Waiter("Sabastian", 'm');
            Waiter waitressMali = new Waiter("Mali", 'f');
            Chef chefOff = new Chef("Off");
            Chef chefR = new Chef("R");
            Grill grill1 = new Grill(1);
            Grill grill2 = new Grill(2);
            Mortar mortar1 = new Mortar(1);

            SomtamRestaurantMediator mediator = new SomtamRestaurantMediator();
            mediator.addWaiter(waiterSabastian);
            mediator.addWaiter(waitressMali);
            mediator.addChef(chefOff);
            mediator.addChef(chefR);
            mediator.addGrill(grill1);
            mediator.addGrill(grill2);
            mediator.addMortar(mortar1);

            mediator.handleTask();

            waiterSabastian.takeOrder("SomTamThai", 2);
            waiterSabastian.takeOrder("PlaDukYang", 2);

            Thread.Sleep(3000);

            waitressMali.takeOrder("SomTamPu", 1);
            waitressMali.takeOrder("KaiYang", 5);

            Thread.Sleep(10000);

            waitressMali.takeOrder("SomTamThai", 1);   

            Thread.Sleep(100000);
        }
    }
}
