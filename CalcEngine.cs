namespace Math_Calculator
{
    internal class CalcEngine
    {
       internal void division(string message)

        {
            double num1;
            double num2;
            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            while (num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"Your result is : {num1} / {num2} = " + (num1 / num2));
            double result = num1 / num2;
            Helpers.AddToHistory("division", result);
            Helpers.AddToMemory(result);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }
       internal void multiplication(string message)
        {
            double num1;
            double num2;
            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");

            var result = Console.ReadLine();
            while (string.IsNullOrEmpty(result) || !Double.TryParse(result, out num1))
            {
                Console.WriteLine("not a number, please try again");
                result = (Console.ReadLine());
            }



            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            var result2 = Console.ReadLine();
            while (string.IsNullOrEmpty(result2) || !Double.TryParse(result2, out num2))
            {
                Console.WriteLine("not a number, please try again");
                result2 = (Console.ReadLine());
            }
            Console.WriteLine($"Your result is : {result} * {result2} = " + (num1 * num2));
            double multres = num1 * num2;
            Helpers.AddToHistory($"Multiplication", multres);
            Helpers.AddToMemory(multres);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }
       internal void subtraction(string message)
        {
            double num1;
            double num2;
            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your result is : {num1} - {num2} = " + (num1 - num2));
            double result = num1 - num2;
            Helpers.AddToHistory("subtraction", result);
            Helpers.AddToMemory(result);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }
       internal void addition(string message)
        {
            double num1;
            double num2;

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your result is : {num1} + {num2} = " + (num1 + num2));

            double result = num1 + num2;
            Helpers.AddToHistory("addition", result);
            Helpers.AddToMemory(result);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }

    }
}
