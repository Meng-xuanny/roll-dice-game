

public class GuessingGame
{
    private readonly Dice _dice;
    private const int _initialTries=3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;

    }

    public GameResult Play()
    {
        var diceResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {_initialTries} tries.");

        var triesLeft = _initialTries;
        while(triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number: ");
            if (guess == diceResult)
            {
                return GameResult.Victory;
            }
            Console.WriteLine("Wrong number");
            triesLeft--;
        }
        return GameResult.Loss;
    }

    public static void PrintResult(GameResult result)
    {
        var message = result == GameResult.Victory ? "You win!" : "You lost :(";
        Console.WriteLine(message);
    }
}
