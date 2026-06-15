namespace IntroClasses;

public class Cell
{
    public Character Occupant;
    public char Visuals;
    public Item Item { get; set; }

    public void Display()
    {
        Console.Write(Visuals);
    }
}