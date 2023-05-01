namespace Math_Calculator
{
    public class Helpers
    
    {

        static List<string> calculations;
        static List<string> memo;
        internal static void AddToHistory(string calculationType, double calcresult)
        {
            calculations.Add($"{DateTime.UtcNow} - {calculationType}: - result: {calcresult}");
        }
        internal static void AddToMemory(double calcresult)
        {
            memo.Add($"result: {calcresult}");
        }


        internal static void GetCalc()

        {

            Console.Clear();
            Console.WriteLine("Calculations History");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < calculations.Count; i++)  //counter for elements in history list
            {
                var calculation = calculations[i];
                Console.WriteLine($"{i + 1}] {calculation}");
            }


            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu , X to clear history");
            var OptSelected = Console.ReadLine();
            switch (OptSelected.Trim().ToLower())
            {
                case "x":
                    calculations.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
                    Console.ReadLine();
            }
        }


        internal static void Memory()

        {
            Console.Clear();
            Console.WriteLine("Memory");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < memo.Count; i++)  //counter for elements in memory list
            {
                var memory = memo[i];
                Console.WriteLine($"{i + 1}] {memory}");
            }

            Console.WriteLine("---------------------------\n");
            var isMemOn = true;
            
            string symbol;

            do
            {
                // asking user to choose which calculation to continue
                double num1;
                double num2;
                Console.WriteLine("Type which result you want to continue calculations with and then press Enter");
                var result = Console.ReadLine();
                while (string.IsNullOrEmpty(result) || !Double.TryParse(result, out num1))
                {
                    Console.WriteLine("not a number, please try again");
                    result = (Console.ReadLine());
                }

                Console.Write("Enter second number:");
                var result2 = Console.ReadLine();
                while (string.IsNullOrEmpty(result2) || !Double.TryParse(result2, out num2))
                {
                    Console.WriteLine("not a number, please try again");
                    result2 = (Console.ReadLine());
                }

                //ask user what calculation to perform, or to exit to the menu

                Console.Write("Enter symbol(/,+,-,*) for calculation or q for exit:");
                symbol = Console.ReadLine();


                switch (symbol)
                {
                    case "+":
                        double MemResAdd = num1 + num2;
                        Console.WriteLine("Addition:" + MemResAdd);
                        AddToHistory("addition", MemResAdd);
                        AddToMemory(MemResAdd);
                        break;
                    case "-":
                        double MemResSub = num1 - num2;
                        Console.WriteLine("Subtraction:" + MemResSub);
                        AddToHistory("Subtraction", MemResSub);
                        AddToMemory(MemResSub);
                        break;
                    case "*":
                        double MemResMult = num1 * num2;
                        Console.WriteLine("Multiplication:" + MemResMult);
                        AddToHistory("Multiplication", MemResMult);
                        AddToMemory(MemResMult);
                        break;
                    case "/":
                        double MemResDiv = num1 / num2;
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor:");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("Division:" + MemResDiv);
                        AddToHistory("Division", MemResDiv);
                        AddToMemory(MemResDiv);
                        break;
                    case "q":
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                        Console.ReadLine(); ;
                }
            } while (isMemOn);
        }

        internal static string ValidateResult(string num1)

        {
            while (string.IsNullOrEmpty(num1) || !Double.TryParse(num1, out _))
            {
                Console.WriteLine("not a number, please try again");
                num1 = (Console.ReadLine());
            }
            return num1;
        } //it is not currently in use

    }
}
