using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mathematical expression:");
            var expression = Console.ReadLine();
            var calculator = new SmartCalculator();
            var result = calculator.Calculate(expression);

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
