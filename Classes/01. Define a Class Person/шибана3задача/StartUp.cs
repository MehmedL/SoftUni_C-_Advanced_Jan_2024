

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            Exercise4();

            

        }

        private static void Exercise4()
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

        private static void Exercise3()
        {
            int lines = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }

        private static void Exercise2()
        {
            var person1 = new Person();
            var person2 = new Person(15);
            var person3 = new Person("Pesho", 15);

            Console.WriteLine($"{person1.Name} {person1.Age}");
            Console.WriteLine($"{person2.Name} {person2.Age}");
            Console.WriteLine($"{person3.Name} {person3.Age}");
        }

        private void Exercise1()
        {
            Person Peter = new("Peter", 20);
            Person George = new("George", 18);
            Person Jose = new("Jose", 43);
        }
    }
}
