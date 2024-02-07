using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
            
        Square square = new Square("Red", 3);
        Rectangle rectangle = new Rectangle("Blue", 4, 5);
        Circle circle = new Circle(6, "Green");
            
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
            
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}
    

