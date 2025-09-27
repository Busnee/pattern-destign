using System;

namespace VisitorPattern
{
    interface Doll
    {
        public void accept(Visitor visitor);
    }
    class HumanDoll : Doll
    {
        public void accept(Visitor visitor)
        {
            visitor.visitHumanDoll(this);
        }
    }
    class HumanCatDoll : Doll
    {
        public void accept(Visitor visitor)
        {
            visitor.visitHumanCatDoll(this);
        }
    }
    class CatDoll : Doll
    {
        public void accept(Visitor visitor)
        {
            visitor.visitCatDoll(this);
        }
    }
    class TeddyBear : Doll
    {
        public void accept(Visitor visitor)
        {
            visitor.visitTeddyBear(this);
        }
    }

    interface Visitor
    {
        public void visitHumanDoll(HumanDoll doll);
        public void visitHumanCatDoll(HumanCatDoll doll);
        public void visitCatDoll(CatDoll doll);
        public void visitTeddyBear(TeddyBear doll);
    }
    class SweaterVisitor : Visitor
    {
        public void visitHumanDoll(HumanDoll doll)
        {
            Console.WriteLine("Make Sweater for human doll.");
        }
        public void visitHumanCatDoll(HumanCatDoll doll)
        {
            Console.WriteLine("Make Sweater for human cat doll.");
        }
        public void visitCatDoll(CatDoll doll)
        {
            Console.WriteLine("Make Sweater for cat doll.");
        }
        public void visitTeddyBear(TeddyBear doll)
        {
            Console.WriteLine("Make Sweater for teddy bear doll.");
            
        }
    }
    class SongkranShirtVisitor : Visitor
    {
        public void visitHumanDoll(HumanDoll doll)
        {
            Console.WriteLine("Make Songkran shirt for human doll.");
        }
        public void visitHumanCatDoll(HumanCatDoll doll)
        {
            Console.WriteLine("Make Songkran shirt for human cat doll.");
        }
        public void visitCatDoll(CatDoll doll)
        {
            Console.WriteLine("Make Songkran shirt for cat doll.");
        }
        public void visitTeddyBear(TeddyBear doll)
        {
            Console.WriteLine("Make Songkran shirt for teddy bear doll.");
        }
    }
    class BeanieVisitor : Visitor
    {
        public void visitHumanDoll(HumanDoll h)
        {
            Console.WriteLine("Make Beanie for human doll.");
        }
        public void visitHumanCatDoll(HumanCatDoll hc)
        {
            Console.WriteLine("Make Beanie for human cat doll.");
        }
        public void visitCatDoll(CatDoll c)
        {
            Console.WriteLine("Make Beanie for cat doll.");
        }
        public void visitTeddyBear(TeddyBear b)
        {
            Console.WriteLine("Make Beanie for teddy bear doll.");
            
        }
    }
    class CapVisitor : Visitor
    {
        public void visitHumanDoll(HumanDoll h)
        {
            Console.WriteLine("Make Cap for human doll.");
        }
        public void visitHumanCatDoll(HumanCatDoll hc)
        {
            Console.WriteLine("Make Cap for human cat doll.");
        }
        public void visitCatDoll(CatDoll c)
        {
            Console.WriteLine("Make Cap for cat doll.");
        }
        public void visitTeddyBear(TeddyBear b)
        {
            Console.WriteLine("Make Cap for teddy bear doll.");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HumanDoll humanDoll = new HumanDoll();
            HumanCatDoll humanCatDoll = new HumanCatDoll();
            CatDoll catDoll = new CatDoll();
            TeddyBear teddyBear = new TeddyBear();

            SweaterVisitor sweaterVisitor = new SweaterVisitor();
            SongkranShirtVisitor songkranShirtVisitor = new SongkranShirtVisitor();
            BeanieVisitor beanieVisitor = new BeanieVisitor();
            CapVisitor capVisitor = new CapVisitor();

            sweaterVisitor.visitHumanDoll(humanDoll);
            beanieVisitor.visitHumanDoll(humanDoll);
            Console.WriteLine();

            songkranShirtVisitor.visitHumanCatDoll(humanCatDoll);
            Console.WriteLine();

            capVisitor.visitCatDoll(catDoll);
            Console.WriteLine();

            sweaterVisitor.visitTeddyBear(teddyBear);
            Console.WriteLine();
        }
    }
}