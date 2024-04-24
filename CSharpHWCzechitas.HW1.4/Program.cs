/*
 Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím. Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
       Např.
       Hádej číslo: 10
       Číslo je menší, hádej znovu: 5
       Číslo je větší, hádej znovu: 7
       To je správně!
*/

Random random = new Random();

int randomNumber = random.Next(1, 11);

int givenNumber = GetInputFromUser("Guess a number between 1 and 10", 1, 10);

while (true)
{
    if (randomNumber == givenNumber)
    {
        Console.WriteLine("Bingo!");
        break;
    }
    else if (givenNumber > randomNumber)
    {
        Console.WriteLine("My number is smaller");
    }
    else if (givenNumber < randomNumber)
    {
        Console.WriteLine("My number is bigger");
    }

    givenNumber = GetInputFromUser("Guess again", 1, 10);
}

int GetInputFromUser(string message, int min, int max)
{
    int value;
    bool isNumber;
    do
    {
        Console.WriteLine(message);
        string? input = Console.ReadLine();
        isNumber = int.TryParse(input, out value);
    } while (isNumber is false || value < min || value > max);

    return value;
}


