namespace Math_Calculator
{
    internal class CalcEngine
    {
       internal  void division(string message)

        {
            double num1;
            double num2;
            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            //var result = Console.ReadLine();
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
            while (string.IsNullOrEmpty(result2) || !Double.TryParse(result2, out num2))
            {
                Console.WriteLine("not a number, please try again");
                result2 = (Console.ReadLine());
            }

            while (num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"Your result is : {num1} / {num2} = " + (num1 / num2));
            double divresult = num1 / num2;
            Helpers.AddToHistory("division", divresult);
            Helpers.AddToMemory(divresult);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }
       internal  void multiplication(string message)
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

            Console.WriteLine($"Your result is : {result} * {result} = " + (num1*num2));
            double multresult = num1 * num2;
            Helpers.AddToHistory($"Multiplication", multresult);
            Helpers.AddToMemory(multresult);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }
       internal  void subtraction(string message)
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

            Console.WriteLine($"Your result is : {num1} - {num2} = " + (num1 - num2));
            double subresult = num1 - num2;
            Helpers.AddToHistory("subtraction", subresult);
            Helpers.AddToMemory(subresult);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }
       internal  void addition(string message)
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

            Console.WriteLine($"Your result is : {num1} + {num2} = " + (num1 + num2));

            double addresult = num1 + num2;
            Helpers.AddToHistory("addition", addresult);
            Console.Write("Press any key to go back to main menu...");
            Console.ReadKey();
        }

    }
}
  