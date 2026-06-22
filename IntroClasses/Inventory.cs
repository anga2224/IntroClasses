namespace IntroClasses;

public class Inventory
{
    private List<Item> _items = [];

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public void Display()
    {
        int x = 40;
        int y = 1;
        Console.SetCursorPosition(x,y);
        Console.WriteLine("Inventory: ");
        y++;
        foreach (Item item in _items)
        {
            item.Display(new Vector2(x,y));
            y++;
        }
    }

    public void Hide()
    {
        int x = 40;
        for (int y = 1; y <= _items.Count + 1; y++)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine("                    ");
        }
    }
}