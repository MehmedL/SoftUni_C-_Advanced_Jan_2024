
namespace DefiningClasses;
public class Family
{
    private List<Person> people = new List<Person>();

    public void AddMember(Person person)
    {
        people.Add (person);
    }
    public Person GetOldestMember()
    {
        return people.FirstOrDefault(p => p.Age == people.Max(p1 => p1.Age));
    }
}
