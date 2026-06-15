using System;
using System.Collections.Generic;

namespace IntroClasses;

public class NPC : Character
{
    List<Vector2> availableDirections = [
        new Vector2(-1,0), //w lewo
        new Vector2(1,0), //w prawo
        new Vector2(0,-1), //w górę
        new Vector2(0,1) //w dół
    ];
    public NPC(char avatar, Vector2 Startingposition, Map map) : base(avatar, Startingposition, map)
    {
    }

    public override bool TakeTurn(Map map)
    {
        Console.SetCursorPosition(_position.X, _position.Y);
        Cell cell = map.GetCell(_position.X, _position.Y);
        
        int index = Random.Shared.Next(availableDirections.Count); //indeks od 0 do 3, mozna podac tylko max nie trzeba dawac 0 
        Vector2 direction = availableDirections[index]; 
        if (Move(direction, map))
        {
            cell.Display();
            cell.Occupant = null;
        }
        Display();
        return true;
    }
}
        /*int targetX = Random.Shared.Next(-1,2); // shared przechowuje jakias generator losowych liczb 
        // piersza minimalna która się wylosuje, a druga to ta która się nie wylosuje tylko liczba o jeden mniejsza
        int targetY = Random.Shared.Next(-1,2);*/
        //  Move(availableDirections[index].X, availableDirections[index].Y); takie samo działanie
