namespace InterfaceLecture
{
    public class Rectangle : IShape
    {
        public int Length {get; set;}
        public int Width {get; set;}
        public string ShapeType {get; set;}


        public int GetArea() //Have to have the methods from Interface
        {
            return Length * Width;
        }

        public int GetPerimeter() //Have to have the methods from Interface
        {
            return (Length * 2) + (Width * 2);
        }
    }
}