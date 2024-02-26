using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            //Excersise1();
            //Excersise2();
            //Exersise3();

            Exersise4();
        }

        private static void Exersise4()
        {
            List<Person> people = new List<Person>();
            int lines = int.Parse(Console.ReadLine());


            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(input[0], int.Parse(input[1])));

            }

            var result = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name);

            foreach (Person person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

        private static void Exersise3()
        {
            
            int lines = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }

        private static void Excersise2()
        {
            Person person1 = new Person();
            Person person2 = new Person(15);
            Person person3 = new Person("Mehmed", 21);

            Console.WriteLine($"{person1.Name} : {person1.Age}");
            Console.WriteLine($"{person2.Name} : {person2.Age}");
            Console.WriteLine($"{person3.Name} : {person3.Age}");
        }

        private static void Excersise1()
        {
            Person Peter = new Person
            {
                Name = "Peter",
                Age = 20
            };
            Person George = new Person("George", 18);
            Person Jose = new Person("Jose", 43);

            Console.WriteLine($"{Peter.Name} : {Peter.Age}");
            Console.WriteLine($"{George.Name} : {George.Age}");
            Console.WriteLine($"{Jose.Name} : {Jose.Age}");
        }

    }
}
