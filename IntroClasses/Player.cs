namespace IntroClasses;

public class Player
{
    private int _x;
    private int _y;
    private string _avatar = "@";

    public void Display()
    {
        Console.SetCursorPosition(_x, _y); //powoduje że snake się tworzy działa jak insert
        Console.Write(_avatar); //wypisuje w konkretnym miejscu
    } //CTRL+H zastępowanie

    public void Move(int diffX, int diffY)
    {
        int targetX = _x + diffX;
        _x += diffX;
        _y += diffY;
    }
    public bool TakeTurn()
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(_x, _y);
        Console.Write(" ");
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
}
