using System;

namespace Selection83
{
    public class Program { 
        public static string PassFail (int mark) {
            var grade = "Fail";
            if (mark >= 40)
            {
                grade = "Pass";

                if (mark >= 60)
                {
                    grade += " with Merit";
                }
                else if (mark >= 75)
                {
                    grade += " with Distinction";
                }
            }
            else
            {
                grade = "Fail";
            }
            return grade;
        }

        public static string Priority(int level)
        {
            string priority = "Code";
            switch (level)
            {
                case 3:
                    priority = priority + " Red";
                    break;
                case 2:
                case 1:
                    priority = priority + " Amber";
                    break;
                case 0:
                    priority = priority + " Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }

            return priority;
        }

        private static string[] _diningTable = { "Amy", "Bob", "Cath", "Dan" };

        public static void SeatDiner(int pos, string name)
        {
            if (pos < 0 || pos >= _diningTable.Length)
            {
                throw new ArgumentException($"The dining table does not have a position {pos}");
            }
            _diningTable[pos] = name;
        }


        static void Main(string[] args)
        {
            

            try { SeatDiner(5, "George"); }
            catch (ArgumentException e)
            {
                Console.WriteLine("Exception thrown: " + e.Message);
            }

            Console.WriteLine("Hello World!");
        }}
    
        
    }

