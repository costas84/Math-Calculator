using System;

var date = DateTime.UtcNow;

var calculations = new List<string>();

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{

    var isCalcOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Hello {name}. It's {date}. This is your math's calculation. That's great that you're working on improving yourself");
        Console.WriteLine("\n");
        Console.WriteLine(@$"
What calculation would you like to do? Choose from the options below:
V - View history
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
        Console.WriteLine("---------------------------------------------");

        var CalcSelected = Console.ReadLine();

        switch (CalcSelected.Trim().ToLower())
        {
            case "v":
                GetCalc();
                break;
            case "a":
                addition("Addition");
                break;
            case "s":
                subtraction("Subtraction");
                break;
            case "m":
                multiplication("Multiplication");
                break;
            case "d":
                division("Division");
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

void GetCalc()
{
    Console.Clear();
    Console.WriteLine("Calculations History");
    Console.WriteLine("---------------------------");
    foreach (var calculation in calculations)
    {
        Console.WriteLine(calculation);
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

void division(string message)

{
    int num1;
    int num2;
    var score = 0;
    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your result is : {num1} / {num2} = " + (num1 / num2));
    score++;
    AddToHistory(score, "Division");
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}




void multiplication(string message)
{
    int num1;
    int num2;
    var score = 0;
    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your result is : {num1} * {num2} = " + (num1 * num2));
    score++;
    AddToHistory(score, "Multiplication");
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}

void subtraction(string message)
{
    int num1;
    int num2;
    var score = 0;
    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your result is : {num1} - {num2} = " + (num1 - num2));
    score++;
    AddToHistory(score, "Subtraction");
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}

void addition(string message)
{
    int num1;
    int num2;
    var score = 0;
    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your result is : {num1} + {num2} = " + (num1 + num2));
    score++;
    AddToHistory(score, "Addition");
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}

void AddToHistory(int calculationscore, string calculationType)
{
    calculations.Add($"{DateTime.Now} - {calculationType}: {calculationscore} x times");
}

