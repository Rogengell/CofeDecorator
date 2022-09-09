class Program
{
    public abstract class Coffe
    {
        public abstract double Cost(); 
        public abstract string Description(); 
    }

    public abstract class Decorator : Coffe
    {
    }

    #region Decorator
    public class Whip : Decorator
    {
        private Coffe b;

        public Whip(Coffe b)
        {
            this.b = b;
        }

        public override double Cost()
        {
            return Math.Round(0.1 + b.Cost(), 2, MidpointRounding.AwayFromZero);
        }

        public override string Description()
        {
            return b.Description() + " and Whip";
        }

    }

    public class Milk : Decorator
    {
        private Coffe b;

        public Milk(Coffe b)
        {
            this.b = b;
        }

        public override double Cost()
        {
            return Math.Round( 0.15 + b.Cost(),2,MidpointRounding.AwayFromZero);
        }

        public override string Description()
        {
            return b.Description() + " and Milk";
        }

    }

    public class Sugar : Decorator
    {
        private Coffe b;

        public Sugar(Coffe b)
        {
            this.b = b;
        }

        public override double Cost()
        {
            return Math.Round(0.2 + b.Cost(), 2, MidpointRounding.AwayFromZero);
        }

        public override string Description()
        {
            return b.Description() + " and Sugar";
        }

    }

    #endregion

    #region Catagories

    public class HouseBlend : Coffe 
    {
        public override double Cost()
        {
            return 1.2;
        }

        public override string Description()
        {
            return "HouseBlend"; 
        }
    }

    public class DarkRoast : Coffe 
    {
        public override double Cost()
        {
            return 1.1;
        }

        public override string Description()
        {
            return "DarkRoast"; 
        }
    }

    public class Decaf : Coffe 
    {
        public override double Cost()
        {
            return 1.4;
        }

        public override string Description()
        {
            return "Decaf";
        }
    }

    #endregion

    static void Main(string[] args)
    {
        Coffe houseBlend = new HouseBlend();
        Console.WriteLine(houseBlend.Description() + " " + houseBlend.Cost());

        houseBlend = new Whip(houseBlend);
        Console.WriteLine(houseBlend.Description() + " " + houseBlend.Cost());

        houseBlend = new Milk(houseBlend);
        Console.WriteLine(houseBlend.Description() + " " + houseBlend.Cost());

        Console.WriteLine();

        Coffe darkRoast = new DarkRoast();
        Console.WriteLine(darkRoast.Description() + " " + darkRoast.Cost());

        darkRoast = new Whip(darkRoast);
        Console.WriteLine(darkRoast.Description() + " " + darkRoast.Cost());

        darkRoast = new Milk(darkRoast);
        Console.WriteLine(darkRoast.Description() + " " + darkRoast.Cost());

        darkRoast = new Sugar(darkRoast);
        Console.WriteLine(darkRoast.Description() + " " + darkRoast.Cost());

        Console.WriteLine();

        Coffe decaf = new Decaf();
        Console.WriteLine(decaf.Description() + " " + decaf.Cost());

        decaf = new Milk(decaf);
        Console.WriteLine(decaf.Description() + " " + decaf.Cost());

        decaf = new Sugar(decaf);
        Console.WriteLine(decaf.Description() + " " + decaf.Cost());


        Console.ReadLine();
    }
}