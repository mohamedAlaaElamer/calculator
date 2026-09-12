namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";

            do
            {

                Console.WriteLine("Welcome to the Calculator!");

                Console.WriteLine("---------------------------------");

                Console.WriteLine("Please enter the first number:");
                string firstNumber = Console.ReadLine();

                Console.WriteLine("Please enter the second number:");
                string secondNumber = Console.ReadLine();

                Console.WriteLine("Please enter the operation (+, -, *, /):");
                string operation = Console.ReadLine();

                if (operation == "+")
                {
                    double result = double.Parse(firstNumber) + double.Parse(secondNumber);
                    Console.WriteLine($"The result is: {result}");
                }
                else if (operation == "-")
                {
                    double result = double.Parse(firstNumber) - double.Parse(secondNumber);
                    Console.WriteLine($"The result is: {result}");
                }
                else if (operation == "*")
                {
                    double result = double.Parse(firstNumber) * double.Parse(secondNumber);
                    Console.WriteLine($"The result is: {result}");
                }
                else if (operation == "/")
                {
                    double result = double.Parse(firstNumber) / double.Parse(secondNumber);
                    Console.WriteLine($"The result is: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please use +, -, *, or /.");
                }

                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            Console.WriteLine("Thank you for using the Calculator!");


        }
    }
}
