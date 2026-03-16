namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        bool isPlaying = true;
        Player hero = new Player();
        hero.Display();
        while (isPlaying)
        {
            isPlaying = hero.TakeTurn();
        }
        
        Console.WriteLine("Goodbye!");
    }
}