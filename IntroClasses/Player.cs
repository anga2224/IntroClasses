using System.Runtime.Intrinsics;

namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKey, Vector2> _inputMap;

    public Player(Vector2 startingPosition, Dictionary<ConsoleKey, Vector2> inputMap) : base(startingPosition) //wywołuje kontstrukor z klasy charakter
    {
        _inputMap = inputMap; //nie mozna zmienic wartosci poza konstruktorem
    }
    public override bool TakeTurn(Map map)
    {
        bool isPlaying = true;
        var input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(map.GetCell(_position.X, _position.Y).Visuals);
        if (_inputMap.ContainsKey(input.Key))
        {
            Vector2 direction = _inputMap[input.Key];
            Move(direction);
        }
        else
        {
        switch (input.Key)
        {
            case ConsoleKey.Q:
              isPlaying = false;
            break;
        }
        }
        Display();
        return isPlaying;
    }
}
