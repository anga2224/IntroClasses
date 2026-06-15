using System;

namespace IntroClasses;

public abstract class Character : GameObject
{
    private List<Item> _inventory;
    public Character(char avatar, Vector2 startingPosition, Map map) : base(avatar, startingPosition)
    {
        _inventory = [];
        Cell cell = map.GetCell(_position.X, _position.Y);
        cell.Occupant = this; //this to ja zajmuje to
    }
    public bool Move(Vector2 direction, Map map)
    {
        return Move(direction.X, direction.Y,map);
    }

    public bool Move(int diffX, int diffY, Map/*typ danych*/ map/*nazwa*/)
    {
        int targetX = _position.X + diffX;
        int targetY = _position.Y + diffY;
        
        if (targetY >= 0 && targetY < Console.BufferHeight && targetY < map.GetHeight())
        {
            
            if (targetX >= 0 && targetX < Console.BufferWidth && targetX < map.GetRowWidth(targetY))
            {
                Cell cell = map.GetCell(targetX, targetY);
                if (cell.Visuals != '#' && cell.Occupant == null)
                {
                    _position.Y =  targetY;
                    _position.X =  targetX;
                    cell.Occupant = this;

                    if (cell.HasItem())
                    {
                        //Item item = cell.TakeItem();
                       // AddItem(item); to samo obie robią //dodawanie itemu do inventory
                       AddItem(cell.TakeItem());
                    }
                    return true;
                }
            }
        }
        return false;
    }

    public void AddItem(Item item)
    {
        _inventory.Add(item); //dodawanie itemu do inventory
    }
    
    public abstract bool TakeTurn(Map map); //ten kto dziedziczy sam implementuje i wszyscy muszą mieć

}

