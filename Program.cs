using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace InterfaceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square(){Side = 5, ShapeType = "Square"};
            Triangle myTriangle = new Triangle(){Base = 5, SideOne = 5, SideTwo = 5, Height = 5, ShapeType = "Triangle"};
            Rectangle myRectangle = new Rectangle(){Length = 5, Width = 10, ShapeType = "Rectangle"};
            // System.Console.WriteLine(mySquare.GetArea());
            // System.Console.WriteLine(myTriangle.GetArea());
            // System.Console.WriteLine(myRectangle.GetArea());

            // System.Console.WriteLine(mySquare.GetPerimeter());
            // System.Console.WriteLine(myTriangle.GetPerimeter());
            // System.Console.WriteLine(myRectangle.GetPerimeter());

            List<IShape> myShapes = new List<IShape>(); //Using interface and adding shapes is using polymorphism
            myShapes.Add(myRectangle);
            myShapes.Add(myTriangle);
            myShapes.Add(mySquare);

            foreach (IShape shape in myShapes)
            {
                System.Console.WriteLine("For the {0} The area is {1} and the perimetere is {2}" , shape.ShapeType, shape.GetArea(), shape.GetPerimeter()); //0 and 1 represent placements
            }            
        }
    }
}
