//Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.

int firstNumber = GetInputFromUser("Give me the first number");
int secondNumber = GetInputFromUser("Give me the second number");
Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
int GetInputFromUser(string message)
{
    int value;
    bool isNumber;
    do
    {
        Console.WriteLine(message);
        string? input = Console.ReadLine();
        isNumber = int.TryParse(input, out value);
    } while (isNumber is false);
    return value;
}


