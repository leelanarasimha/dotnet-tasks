showWelcome();
var firstNumber = getInputNumber(1);
var secondNumber = getInputNumber(2);
showOptions();
var selectedOption = getSelectedOption();

var outputValue = calculate(firstNumber, secondNumber, selectedOption);
Console.WriteLine("Value is " + outputValue);

int calculate(int firstNumber, int secondNumber, string selectedOption)
{
    var option = selectedOption.ToLower();

    switch (option)
    {
        case "a":
            return firstNumber + secondNumber;
        case "s":
            return firstNumber - secondNumber;
        case "m":
            return firstNumber * secondNumber;
        case "d":
            return firstNumber / secondNumber;
        default:
            return 0;

    }
}


string getSelectedOption()
{
    var selectedOption = Console.ReadLine();
    return selectedOption;
}


int getInputNumber(int option)
{
    var name = "Enter Second Number";
    if (option == 1)
    {
        name = "Enter First Number";
    }
    Console.WriteLine(name);
    var num = Console.ReadLine();
    return int.Parse(num);

}


void showWelcome()
{
    Console.WriteLine("Welcome to the Calculator");
}

void showOptions()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[A]dd numbers");
    Console.WriteLine("[S]ubtract numbers");
    Console.WriteLine("[M]ultiply numbers");
    Console.WriteLine("[D]ivide numbers");
}