// 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

Console.WriteLine($"Current date & time: {DateTime.Now}");

// 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

DateTime dateOfBirth = new DateTime(1997, 3, 5);
Console.WriteLine($"Number of days: {(DateTime.Now - dateOfBirth).TotalDays}");

// 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

List<string> myList = new List<string>() { "apple", "pear", "lemon", "orange", "peach"};

// 4. Smaž z tohoto listu libovolnou hodnotu.

myList.Remove("pear");

// 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

Console.WriteLine(myList.Contains("apple"));

// 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
//foreach (string polozka in myList) { return polozka; };

Console.WriteLine($"{myList.Count}:{ string.Join(",", myList)}");

// 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

Dictionary<string, double> myDictionary = new Dictionary<string, double>()
{
    {"cheese", 59.90 },
    {"bread", 65.90 },
    {"milk", 33.90 },
    {"butter", 49.90 },
};

// 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
double price = 0;
string item = "bread";
if (myDictionary.ContainsKey(item))
{
    myDictionary.TryGetValue(item, out price);
    Console.WriteLine($"This item ({item}) costs {price}");
}
else
{
    Console.WriteLine($"This item ({item}) is not on the list");
};

// 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.

double newItemPrice = 40.90;
if (myDictionary.ContainsKey(item))
{
    myDictionary.TryGetValue(item, out price);
    myDictionary[item] = price + newItemPrice;
}
