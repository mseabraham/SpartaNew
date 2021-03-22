using System;

namespace Shape_83
{
    public abstract class Shape
    {
        public abstract int CalculateArea();
    }

    

    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle() { }

        public override int CalculateArea()
        {
            return _width * _height;
        } 
    }

    

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
