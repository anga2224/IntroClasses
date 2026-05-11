namespace IntroClasses;

public abstract class Character
{
    protected Vector2 _position = new Vector2(4,2);
    private string _avatar = "@";
    

    public Character(Vector2 startingPosition)
    {
        _position = startingPosition;
    }

    public void Display()
    {
        Console.SetCursorPosition(_position.X, _position.Y); 
        Console.Write(_avatar);
    }

    public void Move(Vector2 direction)
    {
        Move(direction.X, direction.Y);
    }

    public void Move(int diffX, int diffY)
    {
        int targetX = _position.X + diffX;
        if (targetX >= 0 && targetX < Console.BufferWidth)
        {
            _position.X =  targetX;
        }
        
        int targetY = _position.Y + diffY;
        if (targetY >= 0 && targetY < Console.BufferHeight)
        {
            _position.Y =  targetY;
        }
    }

    public abstract bool TakeTurn(); //ten kto dziedziczy sam implementuje i wszyscy muszą mieć

}