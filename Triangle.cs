namespace InterfaceLecture
{
    public class Triangle : IShape
    {
        public int Base {get; set;}

        public int SideOne {get; set;}

        public int SideTwo {get; set;}

        public int Height {get; set;}
        
        public string ShapeType {get; set;}


        public int GetArea() //Have to have the methods from Interface
        {
            return  (int)(.5 * Base * Height);
        }

        public int GetPerimeter() //Have to have the methods from Interface
        {
            return Base + SideOne + SideTwo;
        }
    }
}