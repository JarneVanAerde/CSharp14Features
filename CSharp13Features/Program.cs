namespace CSharp13Features;

public class Program
{
    public static void Main()
    {
        var person = GetPerson(42);
        person?.Age = 27;
        
        Console.WriteLine("This person is ");
    }

   
}

