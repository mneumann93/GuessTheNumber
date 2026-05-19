Console.WriteLine("Welcome to 'Guess the Number'! Please write a whole number from 1 to 100:");

Random random = new Random();
int number = random.Next(1, 101);
string userInput = Console.ReadLine();
int userNumber = 0;
int counter = 0;

while (!int.TryParse(userInput, out userNumber))
{
    Console.WriteLine("This is not a whole number! Please try again:");
    userInput = Console.ReadLine();
}

while (number != userNumber)
{
    if (number > userNumber)
    {
        Console.WriteLine("Your number is too low! Try again:");
    }
    else
    {
        Console.WriteLine("Your number is too high! Try again:");
    }
    counter++;
    userInput = Console.ReadLine();
    while (!int.TryParse(userInput, out userNumber))
    {
        Console.WriteLine("This is not a whole number! Please try again:");
        userInput = Console.ReadLine();
    }
}

Console.WriteLine($"Correct! The number was {number}. Try counter: {counter}");
Console.ReadLine();