﻿using System;

class Challanges
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to my coding challange program. There will be a varitey of different functions you will have to choose from. Please pick one.");

        Console.WriteLine("Today we are going to use the number adder called SUM. Please input two number for us to add. /n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input 2nd number");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);


        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(number1int, number2int));
        Console.WriteLine("Let's try converting minutes to seconds.\nGive me 2 numbers to add");


        Console.Write("Enter your age in year: ");
        int ageInYears = int.Parse(Console.ReadLine());

        int ageInDays = AgeInDays(ageInYears);

        Console.WriteLine("Your age is days is: " + ageInDays + " days.");

        bool originalValue1 = true;
        boolreversedValue1 = ReverseBoolean(originalValue1);
        Console.WriteLine($"Original: {oringinalValue1}, Reversed: {reversedValue1}");

        bool oringinalValue2 = false;
        bool reversedValue2 = ReversBoolean(oringinalValue2);
        Console..WriteLine($"Original: {oringinalValue2}, Reversed: {reversedValue2}")

        Console.WriteLine("Enter a number of hours:");
        int hours = int.Parse(Console.ReadLine());
        int seconds = ConvertHoursToSeconds(hours);
        Console.WriteLine($"{hours} hour(s) is equal to {seconds} seconds.");

    }

    public static int Sum(int number1, int number2)
    { 
        return number1 + number2;
    }

    static int AgeInDays(int ageInYears)
    {
        int daysInYear = 365;
        return ageInYears * daysInYear;
    }

    static bool ReverseBoolean(bool value)
    {
        return !value;
    }
    
    static int ConvertHoursToSeconds(int hours)
    {
        return hours * 3600; 
    }

}
  