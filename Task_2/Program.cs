using System;

public class TaskTwo
{
    public static void Main(string[] args)
    {
        // Ex1
        Console.WriteLine("Enter two numbers");
        double num = double.Parse(Console.ReadLine());
        double num1 = double.Parse(Console.ReadLine());

        if (num > num1)
        {
            Console.WriteLine($"{num} is higher then {num1}");
        }
        else if (num < num1)
        {
            Console.WriteLine($"{num} is less then {num1}");
        }
        else if (num == num1)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        //Ex2

        Console.WriteLine("Enter any number:");
        int num22 = int.Parse(Console.ReadLine());
        if (num22 > 5 && num22 < 10)
        {
            Console.WriteLine("Your number is higher then 5 and less then 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }


        //Ex3

        Console.WriteLine("Enter any number:");
        int num3 = int.Parse(Console.ReadLine());
        if (num3 == 5 || num3 == 10)
        {
            Console.WriteLine("Your number either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        //Ex4

        Console.WriteLine("Enter the deposit amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double interestRate;

        if (amount < 100)
        {
            interestRate = 0.05;
        }
        else if (amount >= 100 && amount <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double totalWithInterest = amount + (amount * interestRate);
        Console.WriteLine("Deposit amount including interest: " + totalWithInterest);

        //Ex5
        Console.WriteLine("Enter deposit number: ");
        double num5 = double.Parse(Console.ReadLine());
        double interestRate2;
        if (num5 < 100)
        {
            interestRate2 = 0.05;
        }
        else if (num5 > 100 && num5 < 200)
        {
            interestRate2 = 0.07;
        }
        else
        {
            interestRate2 = 0.1;
        }
        double finalAmount = num5 + (num5 * interestRate2) + 15;

        Console.WriteLine("Deposit amount including interest and bonuses: " + finalAmount);

        //Ex6

        Console.WriteLine("Enter operation number: 1)+ 2)- 3)*");
        string operation = Console.ReadLine();


        switch (operation)
        {
            case "1":
                Console.WriteLine("Addition");
                break;
            case "2":
                Console.WriteLine("Subtraction");
                break;
            case "3":
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }

        //Ex7
        Console.WriteLine("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operation number: 1)+ 2)- 3)*");
        string operation2 = Console.ReadLine();


        switch (operation2)
        {
            case "1":
                Console.WriteLine($"Result of addition: {a + b}");
                break;
            case "2":
                Console.WriteLine($"Result of subtraction: {a - b}");
                break;
            case "3":
                Console.WriteLine($"Result of multiplication: {a * b}");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }


    }
}
