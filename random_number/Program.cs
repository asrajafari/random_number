Random random = new Random();
int randomNumber = random.Next(0, 101);


Console.WriteLine("Guess a random number between 1 - 100");
int yourGuess = int.Parse(Console.ReadLine());

while (yourGuess != randomNumber)
{
    Console.WriteLine("Guess a number"+ yourGuess);
    //int yourGuess = int.Parse(Console.ReadLine());

    if (yourGuess > randomNumber)
    {
        Console.WriteLine( "your guess is more");
        break;
    }
    else if (yourGuess < randomNumber)
    {
        Console.WriteLine("your guess is less");
        break;
    }
    else
    {
        Console.WriteLine("yep.. its true");
        break;
    }
        Console.WriteLine("game over");
    
}




