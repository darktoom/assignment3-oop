using static assignment3.ICircle;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///1-b) To define a blueprint for a class
            ///2-a) private
            ///3-b) No
            ///4-b) Yes, interfaces can inherit from multiple interfaces
            ///5-d) implements
            ///6-b) No
            ///7-b) No, all members are implicitly public
            ///8- a) To hide the interface members from outside access
            ///9-b) No, interfaces cannot have constructors
            ///10-c) By separating interface names with commas

            ICircle circle = new Circle
            {
                Radius = 5
            };

            
            circle.DisplayShapeInfo(); 

            
            IRectangle rectangle = new Rectangle
            {
                Length = 4,
                Width = 6
            };

           
            rectangle.DisplayShapeInfo();  
        }






    }
    }

