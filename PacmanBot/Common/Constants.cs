using System.Numerics;

namespace PacmanBot.Common;

public class Constants
{
    public static readonly Position s_positionUp = new Position(0, -1);
    public static readonly Position Vector2Down = new Position(0, 1);
    public static readonly Position s_positionRight = new Position(1, 0);
    public static readonly Position s_positionLeft = new Position(-1, 0);
}