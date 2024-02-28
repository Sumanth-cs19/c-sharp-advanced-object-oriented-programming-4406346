// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new {
    Name = "John Doe",
    Age= 45,
    Address = new {
        Street = "123 Main Street",
        City = "Anywhere",
    }
};

var Phoneobj = new {
    Name = "OnePlus",
    Icon = "1+",
    Description = new {
        Model = "10R",
        Processor = "Snapdragon",
    }
};

Console.WriteLine($"{myobj.Name}, {myobj.Address.Street}");
Console.WriteLine($"{myobj}");

Console.WriteLine($"{Phoneobj.Name},{Phoneobj.Description.Model}");
Console.WriteLine($"{Phoneobj}");
// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// To change a value, use non-destructive mutation and "with" clause
var myobj2 = myobj with {Name = "Jane Doe"};
Console.WriteLine($"{myobj2.Name}, {myobj2.Address.Street}");

var Mobileobj = Phoneobj with {Name = "Realme"};
Console.WriteLine($"{Mobileobj.Name}");

// You can check to see if an anonymous object contains a property
Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myobj.GetType().GetProperty("Job") != null}");

Console.WriteLine($"{Phoneobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{Mobileobj.GetType().GetProperty("Icon") != null}");