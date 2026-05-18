namespace IntroClasses;

public class Map
{
    private Cell[][] _cells;

    public void LoadFromFile(string path)
    {
        string[] lines = File.ReadAllLines(path);
        _cells = new Cell[lines.Length][];
        for (var rowindex = 0 ; rowindex < lines.Length; rowindex++)
        {
            var line = lines[rowindex];
            _cells[rowindex] = new Cell[line.Length];
            Cell[] row = _cells[line.Length];
            for (var columnindex = 0; columnindex < line.Length; columnindex++)
            {
                var character = line[columnindex];
                row[columnindex] = new Cell();
                row[columnindex].Visuals = character;
            }
        }
    }

    public void Display()
    {
        Console.SetCursorPosition(0, 0);
        foreach (var row in _cells)
        {
            foreach (var cell in row)
            {
                Console.Write(cell.Visuals);
            }
            Console.WriteLine();
        }
    }
}