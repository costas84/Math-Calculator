using System;
using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

var calculations = new List<string>();

var memo = new List<string>();

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
        Console.WriteLine($"Hello {name}. It's {date}. This is a calculator.");
        Console.WriteLine("\n");
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
                Memory();
                break;
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
    for (int i = 0; i < calculations.Count; i++)
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
    int result = num1 / num2;
    AddToHistory(score, "division", result);
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
    int result = num1 * num2;
    AddToHistory(score, "Multiplication", result);
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
    int result = num1 - num2;
    AddToHistory(score, "subtraction", result);
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
    int result = num1 + num2;
    AddToHistory(score, "addition", result);
    AddToMemory(result);
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}

void AddToHistory(int score, string calculationType, int calcresult)
{
    calculations.Add($"{DateTime.UtcNow} - {calculationType}: used {score} times - result: {calcresult}");  
}



void AddToMemory(int calcresult)
{
    memo.Add($"result: {calcresult}");
}

void Memory()

{
    Console.Clear();
    Console.WriteLine("Memory");
    Console.WriteLine("---------------------------");
    for (int i = 0; i < memo.Count; i++)
    {
        var memory = memo[i];
        Console.WriteLine($"{i + 1}] {memory}");
    }
    Console.WriteLine("---------------------------\n");

    var isMemOn = true;
    do
    {
        Console.WriteLine("Type which result you want to continue calculations with and then press Enter, or X to leave");
        int memselected = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter symbol(/,+,-,*):");
        string symbol = Console.ReadLine();
        int memresult;

        switch (symbol)
        {
            case "+":
                memresult = memselected + secondNumber;
                Console.WriteLine("Addition:" + memresult);
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
                Console.ReadLine(); ;
        }
    } while (isMemOn);
}