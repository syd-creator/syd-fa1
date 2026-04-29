using System;

class Program
{
    static void Main(string[] args)
    {
        string studentName;
        double mark1, mark2, mark3;
        double total, average;

        Console.Write("Enter student name: ");
        studentName = Console.ReadLine();

        // Input + validation for mark 1
        Console.Write("Enter mark 1: ");
        while (!double.TryParse(Console.ReadLine(), out mark1))
        {
            Console.Write("Invalid input. Enter a numeric value for mark 1: ");
        }

        // Input + validation for mark 2
        Console.Write("Enter mark 2: ");
        while (!double.TryParse(Console.ReadLine(), out mark2))
        {
            Console.Write("Invalid input. Enter a numeric value for mark 2: ");
        }

        // Input + validation for mark 3
        Console.Write("Enter mark 3: ");
        while (!double.TryParse(Console.ReadLine(), out mark3))
        {
            Console.Write("Invalid input. Enter a numeric value for mark 3: ");
        }

        // Calculations
        total = mark1 + mark2 + mark3;
        average = total / 3;

        // Decision
        string result;
        if (average >= 50)
        {
            result = "PASS";
        }
        else
        {
            result = "FAIL";
        }

        // Output
        Console.WriteLine("\n----- Student Results -----");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Result: " + result);

        Console.ReadLine();
    }
}