namespace CSharp13Features.ConditionalAssignments;

public class PersonRepository
{
    private List<Person> People { get; } =
    [
        new Person
        {
            Id = 123,
            Age = 26
        }
    ];

    public Person? GetPerson(int id)
    {
        return People.Find(person => person.Id == id);
    }
}