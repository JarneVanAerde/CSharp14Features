namespace UserDefinedCompoundOperators;

public class Channel
{
    public int Subscribers { get; set; }
    public int Members { get; set; }

    public static Channel operator ++(Channel c)
    {
        c.Subscribers++;
        c.Members++;
        return c;
    }
}
