using PacmanBot.Common;

namespace PacmanBot.Domain.Map;

public class Map
{
    private readonly MapCell[,] _cells;

    public Map(MapCell[,] cells)
    {
        _cells = cells;
    }

    private int Height => _cells.GetLength(0);
    private int Width => _cells.GetLength(1);

    public bool TryGetCell(Position position, out MapCell cell)
    {
        cell = null;
        
        if (InRange(position.Left, 0, Width) == false)
            return false;
        
        if (InRange(position.Top, 0, Height) == false)
            return false;

        cell = _cells[position.Top, position.Left];
        return true;
    }

    private bool InRange(int value, int minValue, int maxValue) => 
        value >= minValue && value < maxValue;
}