namespace CSharp14Features.ExtensionMembers;

public static class EnumerableExtensions
{
    extension<TSource>(IEnumerable<TSource> source)
    {
        public bool IsEmpty => !source.Any();
    }
}