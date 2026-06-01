using System.ComponentModel.DataAnnotations;

namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        Console.CursorVisible = false;
        Dictionary<ConsoleKey, Vector2> directions = new Dictionary<ConsoleKey, Vector2>();
        directions[ConsoleKey.A] = new Vector2(-1, 0); //jaki kierunek, w tym słowniku po kluczem ustawic jakąś wartosc
        directions[ConsoleKey.D] = new Vector2(1, 0);
        directions[ConsoleKey.W] = new Vector2(0, -1);
        directions[ConsoleKey.S] = new Vector2(0, 1);
        directions[ConsoleKey.R] = new Vector2(-2, -2);
        
        Map map = new Map();
        map.LoadFromFile("Level.txt");
        
        
        bool isPlaying = true;
        Vector2 startingPosition = new Vector2(6,1);
        Character hero = new Player(startingPosition, map, directions);
        startingPosition.X = 1;
        startingPosition.Y = 1;
        //startingPosition = new Vector2(0, 0);
        Character anotherHero = new NPC(startingPosition, map);
        List<Character> characters = [hero, anotherHero];
        
        map.Display();
        
        foreach (Character character in characters)
        {
            character.Display();
        }
        
        //anotherHero.Display(); //wyswietlanie 
        
        while (isPlaying)
        {
            foreach (Character character in characters) //wszystkie charaktery w liscie
            {
               isPlaying = character.TakeTurn(map);//żeby uzupełnić brakującą mape
            }
        }
        
        Console.WriteLine("Goodbye!");
    }
}