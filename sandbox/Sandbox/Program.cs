using System;

class Circle
{
    private double _radius;

    public void SetRadis(double radius)
    {
        if (radius<0)
        {
            Console.WriteLine("Error, radius must be > 0");
        }

        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius*_radius;
    }
} 
class Program
{
    //static void Main(string[] args)
    //{
        //Console.WriteLine("Hello World!");
    //}

    static void Main(string[] args)
    {
        //Console.WriteLine("");
        Circle mycircle = new Circle();
        mycircle.SetRadis(10);
        Console.WriteLine($"{mycircle.GetRadius()}");
        Console.WriteLine($"{mycircle.GetArea()}");
        Circle mycircle2 = new Circle();
        mycircle2 .SetRadis(20);
        Console.WriteLine($"{mycircle2.GetRadius()}");
        Console.WriteLine($"{mycircle2.GetArea()}");
    }
}