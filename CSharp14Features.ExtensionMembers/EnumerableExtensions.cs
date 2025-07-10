using System.Numerics;

namespace CSharp14Features.ExtensionMembers;

public static class EnumerableExtensions
{
    extension<TSource>(IEnumerable<TSource> source)
    {
        public bool IsEmpty => !source.Any();

        public IEnumerable<TSource> TakeFiveFirstItems()
        {
            return source.Take(5);
        }
    }
}