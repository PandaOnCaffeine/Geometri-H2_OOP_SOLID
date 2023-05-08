using System;

public abstract class Shapes
{
    protected double a;
    public abstract double GetPerimeter();
    public abstract double GetArea();
    public abstract void GetResult();
}

public class Square : Shapes
{
    public Square(double a)
    {
        this.a = a;
    }
    public override double GetPerimeter()
    {
        return a*4;
    }
    public override double GetArea()
    {
        return a * a;
    }
    public override void GetResult()
    {
        Console.WriteLine($"Side a: {a} |Omkreds: {this.GetPerimeter()} |Areal: {GetArea()}");
    }
}

public class Rektangel : Shapes
{
    private double b;
    public Rektangel(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    public override double GetPerimeter()
    {
        return a * 2 + b * 2;
    }
    public override double GetArea()
    {
        return a * b;
    }
    public override void GetResult()
    {
        Console.WriteLine($"Side a: {a} |Side b: {b} |Omkreds: {this.GetPerimeter()} |Areal: {GetArea()}");
    }
}


public class Trapez : Shapes
{
    private double b;
    private double c;
    private double d;
    private double s;
    private double h;
    public Trapez(double a, double b, double c, double d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }
    public override double GetPerimeter()
    {
        return a + b + c + d;
    }
    public override double GetArea()
    {
        s = (a+ b - c + d)/2;
        h = 2 / (a - c) * Math.Sqrt(s * (s - a + c) * (s - b) * (s - d));
        return 0.5 * (a + c) * h;
    }
    public override void GetResult()
    {
        Console.WriteLine($"Side a: {a} |Side b: {b} |Side c: {c} |Side d: {d} |Omkreds: {this.GetPerimeter()} | Areal: {GetArea()}");

    }
}


public class Parallelogram : Shapes
{
    private double b;
    private int v;
    public Parallelogram(double a, double b, int v)
    {
        this.a = a;
        this.b = b;
        this.v = v;
    }
    public override double GetPerimeter()
    {
        return a * 2 + b * 2;
    }
    public override double GetArea()
    {
        return a * b * Math.Sin(v); ;
    }
    public override void GetResult()
    {
        Console.WriteLine($"Side a: {a} |Side b: {b} |vinkel v: {v} |Omkreds: {this.GetPerimeter()} | Areal: {GetArea()}");

    }
}

public class RetVinkelTriangel : Shapes
{
    private double b;
    private double c;
    public RetVinkelTriangel(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double GetPerimeter()
    {
        return a + b + c;
    }
    public override double GetArea()
    {
        return 0.5 * a * b;
    }
    public override void GetResult()
    {
        Console.WriteLine($"Side a: {a} |Side b: {b} |Side c: {c} |Omkreds: {this.GetPerimeter()} | Areal: {GetArea()}");
    }
}