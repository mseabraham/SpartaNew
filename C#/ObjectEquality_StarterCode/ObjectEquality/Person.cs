using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ObjectEquality
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        private string _firstName;
        private string _lastName;
        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Age = age;
        }

        public int Age { get; set; }

        public int CompareTo([AllowNull] Person other)
        {
            if (other == null) return 1;

            if (this._lastName != other._lastName)
            {
                return this._lastName.CompareTo(other._lastName);
            }
            else if (this._firstName != other._firstName)
            {
                return this._firstName.CompareTo(other._lastName);
            }
            else
            {
                return this.Age.CompareTo(other.Age);
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   Age == other.Age;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName, Age);
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
