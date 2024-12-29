using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }
    public interface ICircle : IShape
    {
        double Radius { get; set; }

        public interface IRectangle : IShape
        {
            double Length { get; set; }
            double Width { get; set; }
        }
        public class Circle : ICircle
        {
            public double Radius { get; set; }  

            public double Area => Math.PI * Radius * Radius; 

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Circle with Radius: {Radius} and Area: {Area}");
            }
        }

        public class Rectangle : IRectangle
        {
            public double Length { get; set; }  
            public double Width { get; set; }  

            public double Area => Length * Width;  

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width}, and Area: {Area}");
            }
        }


    }




}
