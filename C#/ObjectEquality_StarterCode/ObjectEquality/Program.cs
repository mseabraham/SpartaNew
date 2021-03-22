using System.Collections.Generic;

namespace ObjectEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            var bobOne = new Person("Bob", "Builder") { Age = 25 };
            var bobTwo = bobOne;
            var areSame = bobOne.Equals(bobTwo);
            
            List<Person> personList = new List<Person>
            {
                new Person("Cath", "Cookson"),
                new Person ("Bob", "Builder"){Age = 25},
                new Person("Dan", "Dare"),
                new Person("Amy", "Mae"){Age = 32}
            };

        var hasBob = personList.Contains(bobOne);
        }

        

    }
}
