using System;

class Calculator
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Console Calculator!");
        bool continueCalculating = true;

        while (continueCalculating)
        {
            // Display menu for operations
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            // Ask user for operation choice
            Console.Write("Enter your choice (1-5): ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            double result = 0.0;
            bool validOperation = true;

            // Perform operation based on user's choice
            switch (choice)
            {
                case 1: // Addition
                    result = PerformOperation(GetNumber("Enter the first number: "), GetNumber("Enter the second number: "), '+');
                    break;
                case 2: // Subtraction
                    result = PerformOperation(GetNumber("Enter the first number: "), GetNumber("Enter the second number: "), '-');
                    break;
                case 3: // Multiplication
                    result = PerformOperation(GetNumber("Enter the first number: "), GetNumber("Enter the second number: "), '*');
                    break;
                case 4: // Division
                    result = PerformOperation(GetNumber("Enter the first number: "), GetNumber("Enter the second number: "), '/');
                    break;
                case 5: // Exit
                    continueCalculating = false;
                    break;
                default:
                    // Handle invalid choice
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                    validOperation = false;
                    break;
            }

            // Display result if the operation was valid and the user didn't choose to exit
            if (validOperation && continueCalculating)
            {
                Console.WriteLine($"Result: {result}");
            }
        }

        // Goodbye message
        Console.WriteLine("Thank you for using the Calculator!");
    }

    // Function to perform arithmetic operations
    static double PerformOperation(double num1, double num2, char op)
    {
        double result = 0.0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // Handle division by zero
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                }
                break;
        }
        return result;
    }

    // Function to get a valid number input from the user
    static double GetNumber(string message)
    {
        Console.Write(message);
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            // Handle invalid number input
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(message);
        }
        return number;
    }
}
