using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StartUp2
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get => name ; private set => name = value; }
        public int Age { get => age; private set => age = value; }

        public int CompareTo([AllowNull] Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }
            return result;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
        /// <summary>
        ///     
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null) return false;
            else return Name == other.Name && Age == other.Age ;
        }
    }
}
