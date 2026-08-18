using Newtonsoft.Json;
using Humanizer;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator for addition");
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            double sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            method();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void method()
        {
            var appInformation = new
            {
                Name = "Calculator",
                Version = 1
            };

            string json = JsonConvert.SerializeObject(appInformation);
            string title = "calculator".Humanize(LetterCasing.Title);
            Console.WriteLine(title + "\n" + json);
        }
    }
}