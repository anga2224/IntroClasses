namespace IntroClasses;

public class Map
{
    private Cell[][] _cells;

    public void LoadFromFile(string path)
    {
        string[] lines = File.ReadAllLines(path);
        _cells = new Cell[lines.Length][];
        for (var rowIndex = 0; rowIndex < lines.Length; rowIndex++)
        {
            var line = lines[rowIndex];
            _cells[rowIndex] = new Cell[line.Length];
            Cell[] row = _cells[rowIndex];

            for (var columnIndex = 0; columnIndex < line.Length; columnIndex++)
            {
                var character = line[columnIndex];
                row[columnIndex] = new Cell();
                row[columnIndex].Visuals = character;
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