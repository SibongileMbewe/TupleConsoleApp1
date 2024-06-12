// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        //Calculate method
        public static (int sum, int product) Calculate(int a, int b)
        {
            return (a  + b, a * b);
        }


        static void Main(string[] args)
        {
            // Prompt the user to enter two integers
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            // Call the Calculate method
            var result = Calculate(num1, num2);

            // Display the results
            Console.WriteLine($"Sum: {result.sum}");
            Console.WriteLine($"Product: {result.product}");

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


}


