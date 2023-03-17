namespace PacmanBot.Common;

public struct Position
{
    public static Position operator +(Position position1, Position position2) =>
        new Position(position1.Left + position2.Left, position1.Top + position2.Top);

    public static Position operator -(Position position1, Position position2) =>
        new Position(position1.Left - position2.Left, position1.Top - position2.Top);

    public Position(int left, int top)
    {
        Left = left;
        Top = top;
    }

    public static Position Up => new Position(0, -1);
    public static Position Down => new Position(0, 1);
    public static Position Forward => new Position(1, 0);
    public static Position Backward => new Position(-1, 0);
    public static Position Zero => new Position(0, 0);
    
    public int Left { get; }
    public int Top { get; }
}