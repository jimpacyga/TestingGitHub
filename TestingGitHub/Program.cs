// See https://aka.ms/new-console-template for more information
using TestingGitHub;

Console.WriteLine("Hello, World!");

Person p = new Person
{
    Age = 42,
    HairColor = "Sandy",
    Name = "Bozo the Clown"
};

Console.WriteLine($"Age '{p.Age}', HairColor '{p.HairColor}'., Name '{p.Name}'.");