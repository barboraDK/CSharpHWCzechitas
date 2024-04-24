// Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.

int numberOfStars = GetInputFromUser("How many stars do you want me to print?");

for (int i = 0; i < numberOfStars; i++)
{
    Console.WriteLine("*");
}
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
