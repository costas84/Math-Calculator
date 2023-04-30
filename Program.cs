using System;
using System.ComponentModel.Design;
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
    while (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Please enter a valid name");
        name = Console.ReadLine();
    }
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

void division(string message)

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
    AddToHistory("division", result);
    AddToMemory(result);
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}




void multiplication(string message)
{
    double num1;
    double num2;
    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    var Num1AsString = Console.ReadLine();
    bool parsesuccess = Double.TryParse(Num1AsString, out num1);
    while (parsesuccess)
    
        num1 = Convert.ToDouble(Console.ReadLine());


        // Ask the user to type the second number.
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your result is : {num1} * {num2} = " + (num1 * num2));
        double result = num1 * num2;
        AddToHistory("Multiplication", result);
        AddToMemory(result);
        Console.Write("Press any key to go back to main menu...");
        Console.ReadKey();
    } 
    

     



void subtraction(string message)
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
    AddToHistory("subtraction", result);
    AddToMemory(result);
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}

void addition(string message)
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
    AddToHistory("addition", result);
    AddToMemory(result);
    Console.Write("Press any key to go back to main menu...");
    Console.ReadKey();
}

void AddToHistory(string calculationType, double calcresult)
{
    calculations.Add($"{DateTime.UtcNow} - {calculationType}: - result: {calcresult}");
}



void AddToMemory(double calcresult)
{
    memo.Add($"result: {calcresult}");
}

void Memory()

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
    double memselectedone;
    double secondNumber;
    string symbol;

    do
    {
        // asking user to choose which calculation to continue
        
        Console.WriteLine("Type which result you want to continue calculations with and then press Enter");  
        memselectedone = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number:");
        secondNumber = Convert.ToDouble(Console.ReadLine());
         
        //ask user what calculation to perform, or to exit to the menu

        Console.Write("Enter symbol(/,+,-,*) for calculation or q for exit:");
        symbol = Console.ReadLine();


        switch (symbol)
        {
            case "+":
                double MemResAdd = memselectedone + secondNumber;
                Console.WriteLine("Addition:" + MemResAdd);
                AddToHistory("addition", MemResAdd);
                AddToMemory(MemResAdd);
                break;
            case "-":
                double MemResSub = memselectedone - secondNumber;
                Console.WriteLine("Subtraction:" + MemResSub);
                AddToHistory("Subtraction", MemResSub);
                AddToMemory(MemResSub);
                break;
            case "*":
                double MemResMult = memselectedone * secondNumber;
                Console.WriteLine("Multiplication:" + MemResMult);
                AddToHistory("Multiplication", MemResMult);
                AddToMemory(MemResMult);
                break;
            case "/":
                double MemResDiv = memselectedone / secondNumber;
                while (secondNumber == 0)
                {
                    Console.WriteLine("Enter a non-zero divisor:");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
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





