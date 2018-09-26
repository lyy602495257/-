using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class FatherShape
{
    private string MyId;
    public FatherShape(string s)
    {
        Id = s;
    }
    public string Id
    {
        get
        {
            return MyId;
        }
        set
        {
            MyId = value;
        }
    }
    public abstract double Area
    {
        get;
    }
    public virtual void Draw()
    {
        Console.WriteLine("Draw Shape Icon");
    }
    public override string ToString()
    {
        return Id + " Area = " + string.Format("{0 :F2}", Area);
    }
}
public class Triangle : FatherShape
{
    private int Side1, Side2, Side3;

    public Triangle(int side1, int side2, int side3, string id) : base(id)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }
    public override double Area
    {
        get
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
    }
    public override void Draw()
    {
        Console.WriteLine("Draw Triangle: " + Side1 + " " + Side2 + " " + Side3);
    }
}
public class Circle : FatherShape
{
    private int myRadius;
    public Circle(int radius, string id) : base(id)
    {
        myRadius = radius;
    }
    public override double Area
    {
        get
        {
            return myRadius * myRadius * System.Math.PI;
        }
    }
    public override void Draw()
    {
        Console.WriteLine("Draw Circle: " + myRadius);
    }
}
public class Square : FatherShape
{
    private int mySide;
    public Square(int side, string id) : base(id)
    {
        mySide = side;
    }
    public override double Area
    {
        get
        {
            return mySide * mySide;
        }
    }
    public override void Draw()
    {
        Console.WriteLine("Draw Square: " + mySide);
    }
}
public class Rectangle : FatherShape
{
    private int myWidth, myHeight;
    public Rectangle(int width, int height, string id) : base(id)
    {
        myWidth = width;
        myHeight = height;
    }
    public override double Area
    {
        get
        {
            return myWidth * myHeight;
        }
    }
    public override void Draw()
    {
        Console.WriteLine("Draw Rectangle: " + myWidth + myHeight);
    }
}
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            FatherShape[] shapes =
            {
                new Triangle(3,3,3,"Triangle"),
                new Circle(1,"Circle"),
                new Square(1,"Square"),
                new Rectangle(1,2,"Rectangle")
            };
            System.Console.WriteLine("Triangle's sides are 3,3,3.");
            System.Console.WriteLine("Circle's radius is 1.");
            System.Console.WriteLine("Square's side is 1.");
            System.Console.WriteLine("Rectangle's width is 1 as well as its height is 2.");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Their areas are as follows:");
            System.Console.WriteLine(" ");
            foreach (FatherShape s in shapes)
            {
                System.Console.WriteLine(s);
            }
        }
    }
}
