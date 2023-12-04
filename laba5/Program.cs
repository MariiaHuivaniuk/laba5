// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.WriteLine("Завдання 1");

        Console.WriteLine("operand1= ");
        double operand1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("operand2= ");
        double operand2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("operation= ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = PerformingTheOperation(operand1, operand2, operation);

        Console.WriteLine($"Результат: {result}");

    }

    static double PerformingTheOperation(double operand1, double operand2, char operation)
    {
        switch (operation)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                return operand1 / operand2;

            default:
                Console.WriteLine("Не вірна операція");
                return double.NaN;
        }

        
        
    }
}


