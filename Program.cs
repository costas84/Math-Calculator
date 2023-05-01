using Math_Calculator;

var menu = new Menu();
var date = DateTime.UtcNow;
var calculations = new List<string>();
var memo = new List<string>();
string name = GetName();

menu.ShowMenu(name, date);
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



