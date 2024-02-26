using System;
using System.Collections.Generic;
using System.Linq;

namespace StartUp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Listy();
            //LakeStartUp();

            PersonEquality();

        }

        private static void PersonEquality()
        {
            List<Person> persons = new List<Person>();

            string comand;
            while ((comand = Console.ReadLine()).ToLower() != "end")
            {
                string[] personProp = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = personProp[0],
                    Age = int.Parse(personProp[1]),
                    Town = personProp[2]
                };
                persons.Add(person);
            }
            int referenceIndex = int.Parse(Console.ReadLine()) - 1;

            Person referencePerson = persons[referenceIndex];

            int equalCount = 0;
            int diffCount = 0;

            foreach (var item in persons)
            {
                if (item.CompareTo(referencePerson) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {persons.Count}");
            }
        }

        private static void LakeStartUp()
        {
            List<int> list = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            Lake lake = new Lake(list);

            string output = string.Join(", ", lake);

            Console.WriteLine(output);
        }

        private static void Listy()
        {
            var input = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            ListyIterator<string> listyIterator = new ListyIterator<string>(input.Skip(1).ToList());
            string comand;
            while ((comand = Console.ReadLine()).ToLower() != "end")
            {
                switch (comand.ToLower())
                {
                    case "print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine("Invalid Operation! ");
                        }

                        break;
                    case "hasnext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "printall":
                        foreach (var item in listyIterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
