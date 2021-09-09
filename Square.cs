using System.Reflection.Emit;
namespace InterfaceLecture
{
    public class Square : IShape //Implement IShape
    {
        public int Side {get; set;}
        public string ShapeType {get; set;}


        public int GetArea() //Have to have the methods from Interface
        {
            return Side * Side;
        }

        public int GetPerimeter() //Have to have the methods from Interface
        {
            return Side * 4;
        }
        
    }
}