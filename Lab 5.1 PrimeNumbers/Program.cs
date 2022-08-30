using Lab_5._1_PrimeNumbers;
bool KeepGoing = false;
Console.WriteLine("Let's locate some primes!");
Console.WriteLine("This applications will find you any prime, in order, from first prime number on.");

while (!KeepGoing)
{
    Console.Write("Which prime number are you looking for? (1 - 25):  ");
    string entryasStr = Console.ReadLine();
    int entry = 0;
    bool isValidNum = int.TryParse(entryasStr, out entry);

    if (!isValidNum)
    {
        Console.WriteLine("That isn't a number, genius.");
    }

    else if (entry < 1 || entry > 25)
    {
        Console.WriteLine("Not in the scope, dope!");
    }
    else if (entry >= 1 || entry <= 25)
    {
        int result = Prime.GetPrime(entry);
        Console.WriteLine($"The number {entry} prime is {result}.");
    }
   

    Console.Write("Would you like to go again? Y/N  ");
    string choice = Console.ReadLine().ToLower();
    if (choice == "yes" || choice == "y")
    {
        KeepGoing = false;
    }
    else if (choice == "no" || choice == "n")
    {
        Console.WriteLine("Bye");
        KeepGoing = true;
    }
}
