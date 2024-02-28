// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
using System.Reflection.Metadata.Ecma335;

Dog dog = new Dog {Name = "Jack", Breed = "German sheppard" , IsTrained=true};
Cat cat = new Cat {Name = "Tom" , Breed ="Persion" , IsDeclawed=true};
Console.WriteLine($"{dog.Name} , {dog.Breed}");
Console.WriteLine($"{cat.Name} , {cat.Breed}");
// TODO: Initializers can be used on anonymous types
var pet = new {Name = "Jimmy" , Breed = "Leo"};
Console.WriteLine($"{pet.Name} , {pet.Breed}");

// TODO: Collections can also be initialized this way
int[] numbers = new int[] {1,2,3,4,5,6};
Console.WriteLine($"{numbers.Length}");
// TODO: Initialize a collection with a set of objects

