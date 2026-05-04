using System.Runtime.Intrinsics;

namespace IntroClasses;

public class Player : Character
{
    public Player(Vector2 startingPosition) : base(startingPosition) //wywołuje kontstrukor z klasy charakter
    {
    }
    public override bool TakeTurn()
    {
        var isPlaying = IsPlaying(out var input);
        switch (input.Key)
        {
            case ConsoleKey.S:
                Move(0, 1);
                break;
            case ConsoleKey.W:
                Move(0, -1);
                break;
            case ConsoleKey.A:
                Move(-1, 0);
                break;
            case ConsoleKey.D:
                Move(1, 0);
                break;
            case ConsoleKey.Q:
              isPlaying = false;
            break;
        }
        Display();
        
        return isPlaying;
    }

    protected bool IsPlaying(out ConsoleKeyInfo input) //dzieci mogą dziedziczyć w protected
    {
        bool isPlaying = true;
        input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        return isPlaying;
    }
}
