namespace CSharp14Features.FieldKeyword;

public class Person
{
    public int Age
    {
        get;
        set { field = value < 1 
                ? throw new AggregateException("Age must be higher or equal to 0") :
                value;
        }
    }
}