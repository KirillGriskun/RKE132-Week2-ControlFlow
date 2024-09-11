﻿// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Enter your age:");
int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 12)
{
    Console.WriteLine("Welcone to Instagram!");
}
if (userAge < 12)
{
    Console.WriteLine("You are too young to register!");
}
*/

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcone to Instagram");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}



