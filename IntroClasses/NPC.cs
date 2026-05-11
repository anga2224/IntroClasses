namespace IntroClasses;

public class NPC : Character
{
    public NPC(Vector2 Startingposition) : base(Startingposition)
    {
    }

    public override bool TakeTurn()
    {
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        int targetX = Random.Shared.Next(-1,2); // shared przechowuje jakias generator losowych liczb 
        // piersza minimalna która się wylosuje, a druga to ta która się nie wylosuje tylko liczba o jeden mniejsza
        int targetY = Random.Shared.Next(-1,2);
        Move(targetX, targetY);
        Display();
        return true;
    }
}