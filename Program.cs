using System;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68);
        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(0);
        CheckForPositiveNegativeZero(1);
        FindMaximum(1,2,3);
        FindMinimum(1,2,3);
        IsDivisibleBy5(30);
        IsDivisibleBy5(31);
        CheckEvenOrOdd(1);
        CheckEvenOrOdd(2);
        CheckVowelOrConsanant('w');
        CheckVowelOrConsanant('e');
        DisplayDayOfWeek(0);

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }
    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number){
        Console.Write("Your number is ");
        if (number > 0){
            Console.WriteLine("positive.");
        } else if (number == 0){
            Console.WriteLine("zero.");
        } else{
            Console.WriteLine("negative.");
        }
    }
    public static void FindMinimum(int num1, int num2, int num3){
        Console.WriteLine("The maximum value is " + Math.Max(Math.Max(num1,num2),num3));
    }
    public static void FindMaximum(int num1, int num2, int num3){
        Console.WriteLine("The minumum value is " + Math.Min(Math.Min(num1,num2),num3));
    }
    public static void IsDivisibleBy5(int number){
        if (number % 5 == 0){
            Console.WriteLine(number + " is divisible by 5.");
        } else{
            Console.WriteLine(number + " is not divisible by 5.");
        }
    }
    public static void CheckEvenOrOdd(int number){
        if (number % 2 == 0){
            Console.WriteLine(number + " is an even number.");
        } else{
            Console.WriteLine(number + " is an odd number.");
        }
    }
    public static void CheckVowelOrConsanant(char letter){
        switch (letter)
        {
            case 'a' or 'e' or 'i' or 'o' or 'u':
                Console.WriteLine(letter + " is a vowel.");
                break;
            default:
                Console.WriteLine(letter + " is a consonant.");
                break;
        }
    }
    public static void DisplayDayOfWeek(int dayCode){
        switch (dayCode){
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
        }
    }
}
