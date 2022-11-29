// Created by: sophie
// Created on: oct 2020
//
// This program calculates area and perimeter of a rectangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        string day = null;
        int age;

        Console.Write("Enter a day of the week: ");
        day = Convert.ToString(Console.ReadLine());

        Console.Write("Enter a day of the week: ");
        age = Convert.ToInt32(Console.ReadLine());

        if ((day == "Thursday" || day == "Tuesday") || (day == "thursday" || day == "tuesday") || (age >= 12 && age <= 21))
        {
            Console.WriteLine("you can get a discount!");
        }
        else
        {
            Console.WriteLine("sorry, you can't get a discount");
        }

        Console.WriteLine("\nDone.");
    }
}