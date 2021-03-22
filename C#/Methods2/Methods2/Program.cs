using System;
using System.Text;

namespace Methods2
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
       
        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static int Mod(int a, int b)
        {
            return a % b;
        }
    }
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var result = DoThis(100, "Tell em wag1", out bool isLarge);
            //Console.WriteLine(isLarge);

            //OrderPizza(anchovies: false, pineapple: false);

            /*var aTuple = ("My", "Name", 25);
            Console.WriteLine(aTuple);

            Console.WriteLine(aTuple.Item3);
            var aNamedTuple = (fname: "Eric", lName: "The Half Bee", age: 123);*/

            /*
            var result = DoThat(10, "This is a aString");
            Console.WriteLine(result);
            Console.WriteLine(result.xsquared);
            var (square, greaterThan10) = DoThat(5, "What??????");
            Console.WriteLine(greaterThan10);*/

            //TUPLES
            /*
            var product = TripleCalc(2, 3, 4, out int sum);
            Console.WriteLine(product + " : " + sum);

            var tuple = TripleCalc(4, 5, 6);
            Console.WriteLine(tuple.product + ":" + tuple.sum);
            */

            //STRING

            /*
            string firsName = "Mike";
            string lastName = "Abe";
            double age = 22.5;


            var string2 = $"{firsName} {lastName} Age: {age:f4}";

            var string3CA = string2.ToCharArray();
            */

            //STRING PARSE
            /*
            Console.WriteLine("How many apples");
            string input =Console.ReadLine();
            bool success = Int32.TryParse(input, out int NumApples);
            if (success)
            {
                Console.WriteLine($"We have {NumApples}");
            }*/

            var sb = new StringBuilder("i love VB");
            sb.Replace("VB", "C#");
            sb.Append(" becase its better!");
            sb.Insert(2, "Really ");
            var result = sb.ToString();

        }

        

        public static int TripleCalc(int a, int b, int c, out int sum) {
            sum = a + b + c;
            return a * b * c; }

        public static (int sum, int product) TripleCalc(int a, int b, int c){ return (a + b + c, a * b * c); }
          

        public static void DoThat (int x, string y, out int xSquared, out bool y_gt_10)
        {
            Console.WriteLine(y);
            y_gt_10 = (x > 10);
            xSquared = x * x;
        }

        /*
        public static (int xsquared, bool y_gt_10) DoThat(int x, string y)
        {
            Console.WriteLine(y);
            var z = (x > 10);
            return (x * x, z);
        }*/

        public static int DoThis(int x, string y, out bool z)
        {
            Console.WriteLine(y);
            z = (x > 10);
            return x * x;
        }

        static void OrderPizza(bool anchovies, bool pineapple,bool mushrooms = false)
        {
            Console.WriteLine("Your Pizza is topped with ");
        }
    }
}
