using System;
using System.Collections.Generic;

namespace OOP_83
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public int Age
        {
            get; set;
        }

        public Person()
        {
            _firstName = "Not";
            _lastName = "Known";
        }
        public Person(string fName, string lName, int age = 18)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }
    }

    public class Spartan
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public Spartan (string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }
    }

    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public int NumPassengers 
        {
            get
            {
                if((_numPassengers > _capacity)||(_numPassengers < 0))
                {
                    return default;
                        
                }
                else
                {
                    return _numPassengers;
                }

            }
            set
            {
                if ((_numPassengers > _capacity) || (_numPassengers < 0))
                {
                    _numPassengers = default;

                }
                else
                {
                    _numPassengers = value;
                }
            } 
        }
        public int Position { get; private set; }

        public Vehicle() 
        {
            _capacity = default;
            _speed = 10;        
         }

        public Vehicle (int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public string Move()
        {
            Position = _speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position = _speed * times;
            return $"Moving along {times} times";
        }

        //HW 2
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class ShoppingList
    {
        public int Bread { get; set; }
        public int Milk { get; set; }
        public int Soap { get; set; }
        public int Potato { get; set; }
        public int Lemon { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Console.WriteLine(result);

            /*
            Person rex = new Person("Tee", "Rex") { Age = 600000001 };

            var list = new ShoppingList()
            {
                Bread = 2,
                Potato = 3,
                Soap = 1
            };

            var list2 = new ShoppingList() { Lemon = 3, Soap = 4 };

            Hunter h = new Hunter("Marion", "Maid", "Nikon") { Age = 32 };
            Console.WriteLine(h.Age);
            Console.WriteLine(h.Shoot());
            Hunter h2 = new Hunter();
            var h3 = new Hunter("Michael", "Bigman", "Canon") { Age = 21 };
            Console.WriteLine( $"Equals h2? {h3.Equals(h3)}");
            Console.WriteLine($"Equals h2? {h.GetHashCode()}");
            Console.WriteLine($"Equals h2? {h.GetType()}");
            Console.WriteLine($"Equals h2? {h.ToString()}");


            Console.WriteLine($"h: {h}");*/

            
    }
}
