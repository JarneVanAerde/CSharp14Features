// See https://aka.ms/new-console-template for more information

using CSharp13Features.ConditionalAssignments;

var personRepository = new PersonRepository();
var person = personRepository.GetPerson(123);
person?.Age = 27;

Console.WriteLine($"Person has age of {person?.Age}");