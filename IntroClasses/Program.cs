using System.ComponentModel.DataAnnotations;

namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        bool isPlaying = true;
        Vector2 startingPosition = new Vector2(4,2);
        Character hero = new Player(startingPosition);
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