using System;
using System.Text.RegularExpressions;
using System.Text;

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


        Console.WriteLine("Enter a number of hours:");
        int hours = int.Parse(Console.ReadLine());
        int seconds = ConvertHoursToSeconds(hours);
        Console.WriteLine("{hours} hour(s) is equal to {seconds} seconds.");

        Console.WriteLine("Enter the number of sides of a polygon:");
        int n = int.Parse(Console.ReadLine());
        int sumOfAngles = CalculateInternalAngleSum(n);
        Console.WriteLine("The sum of the internal angles of a n-sided polygon is {sumOfAngles} degrees.");

        Console.WriteLine("Enter a number from 1 to 12");
        if (int.TryParse(Console.ReadLine(), out int monthnumber));
        {
            string monthName = GetMonthName(monthnumber);
            if (monthName != null)
            {
                Console.WriteLine("The corresponding month is:" + "{monthName}");
            } 
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 12.");
            }
        }
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

    static int ConvertHoursToSeconds(int hours)
    {
        return hours * 3600;
    }

    static int CalculateInternalAngleSum(int n)
    {
        return (n - 2) * 180;
    }

    static string GetMonthName(int monthNumber)
    {
        switch (monthNumber)
        {
            case 1: return "January";
            case 2: return "February";
            case 3: return "March";
            case 4: return "April";
            case 5: return "May";
            case 6: return "June";
            case 7: return "July";
            case 8: return "August";
            case 9: return "September";
            case 10: return "October";
            case 11: return "November";
            case 12: return "December";
            default: return null;
        }
    }
}
