// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());

//Console.WriteLine($"Welcome, {userGender}");

Console.WriteLine("Enter your surname:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Hello. Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Hello, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Hello {userLastName}!");
}
