namespace IntroClasses;

public class Cell
{
    public Character Occupant;
    public char Visuals;
    public Item Item { get; set; }

    public void Display()
    {
        if (Item != null)
        {
            Item.Display();
        }
        else
        {
            Console.Write(Visuals); 
        }
    }

    public bool HasItem()
    {
        return Item != null;
    }

    public void PutItem(Item item)
    {
        Item = item;
    }

    public Item TakeItem()
    {
        Item item =  Item; //jest item
        Item = null; //stwierdzsmy po stanieciu ze j7z nie ma zadnej rzeczy tam
        
        return item; //zapisanie do inventory przez postac ona moze zapisac
    }
}