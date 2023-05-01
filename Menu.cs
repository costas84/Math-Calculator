namespace Math_Calculator
{
    internal class Menu
    {
        CalcEngine engine = new();

        internal void ShowMenu(string name, DateTime date)
        {

            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is a calculator.");
            Console.WriteLine("\n");
            var isCalcOn = true;

            do
            {
                Console.WriteLine(@$"
What calculation would you like to do? Choose from the options below:
V - View history
E - Memory
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("---------------------------------------------");

                var CalcSelected = Console.ReadLine();

                switch (CalcSelected.Trim().ToLower())
                {
                    case "e":
                        Helpers.Memory();
                        break;
                    case "v":
                        Helpers.GetCalc();
                        break;
                    case "a":
                        engine.addition("Addition");
                        break;
                    case "s":
                        engine.subtraction("Subtraction");
                        break;
                    case "m":
                        engine.multiplication("Multiplication");
                        break;
                    case "d":
                        engine.division("Division");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isCalcOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isCalcOn);
        }
    }
}
