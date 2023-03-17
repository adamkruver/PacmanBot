namespace PacmanBot.Domain.Map;

public class MapCell
{
    public MapCell(char symbol)
    {
        Symbol = symbol;
    }

    private char Symbol { get; }
}