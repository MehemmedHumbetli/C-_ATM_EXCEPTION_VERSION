class program
{

    abstract class Shape
    {
        public abstract void perimeter();
        public abstract void area();
        public override string ToString()
        {
            return "This is a shape";
        }
    }


    class Rectangle : Shape
    {
        public double En { get; set; }
        public double Uzunluq { get; set; }

        public override void area()
        {
            Console.WriteLine($"Area = {En * Uzunluq}");
        }
        public override void perimeter()
        {
            Console.WriteLine($"Perimeter = {2 * (En + Uzunluq)}");
        }

        public override string ToString()
        {
            return $"Eni: {En}   Uzunluq: {Uzunluq}";
        }
    }

    class Square : Rectangle
    {
        public double teref { get; set; }

        public override void area()
        {
            Console.WriteLine($"Area = {teref} * {teref}");
        }

        public override void perimeter()
        {
            Console.WriteLine($"Perimeter = {4 * teref}");
        }

        public override string ToString()
        {
            return $"Teref: {teref}";
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override void perimeter()
        {
            Console.WriteLine($"Perimeter = {2 * 3.14 * Radius}");
        }

        public override void area()
        {
            Console.WriteLine($"Area = {3.14 * Radius * Radius}");
        }

        public override string ToString()
        {
            return $"Radius: {Radius}";
        }
    }




    static void Main(string[] args)
    {

    }
}