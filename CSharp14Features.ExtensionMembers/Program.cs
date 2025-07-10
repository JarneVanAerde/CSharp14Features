using CSharp14Features.ExtensionMembers;

var myCollection = Enumerable.Empty<int>();
Console.WriteLine($"My collection is empty: {myCollection.IsEmpty}");

Console.WriteLine($"My birthday is on {DateOnly.Birthday}");