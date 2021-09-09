namespace InterfaceLecture
{
    public interface IShape
    {
         public int GetArea(); //How you create an interface 
         public int GetPerimeter();

         //NEVER ADD A FIELD TO A INTERFACE YOU CAN ADD A PROPERTY
         public string ShapeType {get; set;}

    }
}