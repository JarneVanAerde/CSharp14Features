namespace CSharp14Features.ExtensionMembers;

public static class DateOnlyExtensions
{
    extension(DateOnly) {
        public static DateOnly Birthday => new(1998, 06, 08);
    }
}