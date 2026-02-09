using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square("blue", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("pink", 2, 3);
        shapes.Add(s2);

        Circle s3 = new Circle("purple", 10);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}