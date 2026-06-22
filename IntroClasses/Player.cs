using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;

namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKey, Vector2> _inputMap;

    public Player(char avatar, Vector2 startingPosition, Map map, Dictionary<ConsoleKey, Vector2> inputMap) : base(avatar, startingPosition, map) //wywołuje kontstrukor z klasy charakter
    {
        _inputMap = inputMap; //nie mozna zmienic wartosci poza konstruktorem
    }
    public override bool TakeTurn(Map map)
    {
        bool isPlaying = true;
        var input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Cell cell = map.GetCell(_position.X, _position.Y);
        
        if (_inputMap.ContainsKey(input.Key))
        {
            Vector2 direction = _inputMap[input.Key];
            bool moved = Move(direction, map);
            if (moved)
            {
                cell.Leave();
                cell.Display();
            }
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
