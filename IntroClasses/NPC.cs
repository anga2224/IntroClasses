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
        Move(1,0);
        Display();
        return true;
    }
}