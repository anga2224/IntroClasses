namespace IntroClasses;

public class Cell
{
    public Character Occupant;
    public char Visuals;
    public Item Item { get; set; }

    public void Display()
    {
        if (IsOccupied())
        {
            Occupant.Display();
        }
        else if (HasItem())
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

    public bool IsOccupied()
    {
        return Occupant != null;
    }

    public void PutItem(Item item)
    {
        Item = item;
    }

    public Item TakeItem()
    {
        Item item =  Item; //jest item
        Item = null; //stwierdzsmy po stanieciu ze juz nie ma zadnej rzeczy tam
        
        return item; //zapisanie do inventory przez postac ona moze zapisac
    }
    /// <summary>
    /// Place character on this cell by putting it into Occupent
    /// </summary>
    /// <param name="character">character to put into Occupent field</param>
    public void Occupy(Character character)
    {
        Occupant = character;
    }

    public void Leave()
    {
        Occupant = null;
    }
}