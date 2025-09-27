using System;

namespace DecoratorPattern
{
    public interface Room
    {
        public string getDetail();
        public string clean();
    }
    public class BasicRoom : Room
    {
        int width;
        int height;
        public BasicRoom()
        {
            this.width = 1;
            this.height = 1;
        }
        public BasicRoom(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public string getDetail()
        {
            return "Basic Room(size " + this.width + "x" + this.height + ")";
        }
        public string clean()
        {
            return "Cleaning Room";
        }
    }
    public class RoomDecorator : Room
    {
        private Room room;
        public RoomDecorator(Room r)
        {
            room = r;
        }
        public virtual string getDetail()
        {
            return room.getDetail();
        }
        public virtual string clean()
        {
            return room.clean();
        }
    }
    public class BedDecorator : RoomDecorator
    {
        public BedDecorator(Room r) : base(r)
        {
            
        }
        public override string getDetail()
        {
            return base.getDetail() + " have Bed";
        }
        public override string clean()
        {
            return base.clean() + "\n\t- cleaning Bed";
        }
    }
    public class TvDecorator : RoomDecorator
    {
        public TvDecorator(Room r) : base(r)
        {
            
        }
        public override string getDetail()
        {
            return base.getDetail() + " have TV";
        }
        public override string clean()
        {
            return base.clean() + "\n\t- cleaning TV";
        }
    }
    public class SofaDecorator : RoomDecorator
    {
        public SofaDecorator(Room r) : base(r)
        {
            
        }
        public override string getDetail()
        {
            return base.getDetail() + " have Sofa";
        }
        public override string clean()
        {
            return base.clean() + "\n\t- cleaning Sofa";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BasicRoom r = new BasicRoom(15,20);
            TvDecorator rTv = new TvDecorator(r);
            BedDecorator rTvBed = new BedDecorator(rTv);
            SofaDecorator rTvSofa = new SofaDecorator(rTv);

            BedDecorator bedRoom = rTvBed;
            SofaDecorator livingRoom = rTvSofa;

            Console.WriteLine("Bed Room Detail: " + bedRoom.getDetail());
            Console.WriteLine("Living Room Detail: " + livingRoom.getDetail());
            Console.WriteLine();

            Console.WriteLine("Clean Bed Room\n" + bedRoom.clean());
            Console.WriteLine();
            Console.WriteLine("Clean Living Room\n" + livingRoom.clean());
        }
    }
}