
// See https://aka.ms/new-console-template for more information

// Hours of sleep
Console.WriteLine("Please tell me how long you slept last night?");
string sleep = Console.ReadLine() ?? "0"; // "8" or null (dont want null, give it a default with ??

if (!int.TryParse(sleep, out int sleepParse)) // Syntactic sugar
{
    Console.WriteLine("Please enter a valid number and try again");

    return;
}

// Number of coffees
Console.WriteLine("Please tell me how many coffees you drank?");
string coffees = Console.ReadLine()!;

if (!int.TryParse(coffees, out int coffeesParse)) // Syntactic sugar
{
    Console.WriteLine("Please enter a valid number and try again");

    return;
}


int energy = CalculateEnergy(sleepParse, coffeesParse);

if(energy >= 80)
{
    Console.WriteLine("You're good");
} else if (energy >= 50)
{
    Console.WriteLine("Maybe top up");
} else
{
    Console.WriteLine("Go sleep");
}



int CalculateEnergy(int hoursSlept, int coffeesDrank)
{
    return hoursSlept * 10 + coffeesDrank * 5;
}

