using System.ComponentModel.DataAnnotations;

namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        Dictionary<ConsoleKey, Vector2> directions = new Dictionary<ConsoleKey, Vector2>();
        directions[ConsoleKey.A] = new Vector2(-1, 0); //jaki kierunek, w tym słowniku po kluczem ustawic jakąś wartosc
        directions[ConsoleKey.D] = new Vector2(1, 0);
        directions[ConsoleKey.W] = new Vector2(0, -1);
        directions[ConsoleKey.S] = new Vector2(0, 1);
        bool isPlaying = true;
        Vector2 startingPosition = new Vector2(4,2);
        Character hero = new Player(startingPosition, directions);
        startingPosition.X = 0;
        startingPosition.Y = 0;
        //startingPosition = new Vector2(0, 0);
        Character anotherHero = new NPC(startingPosition);
        List<Character> characters = [hero, anotherHero];
        foreach (Character character in characters)
        {
            character.Display();
        }
        
        //anotherHero.Display(); //wyswietlanie 
        
        while (isPlaying)
        {
            foreach (Character character in characters) //wszystkie charaktery w liscie
            {
               isPlaying = character.TakeTurn();
            }
        }
        
        Console.WriteLine("Goodbye!");
    }
}