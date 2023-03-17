using PacmanBot.Domain.Map;
using PacmanBot.Domain.Unit;
using PacmanBot.Domain.Unit.Movement;

namespace PacmanBot;

public class Program
{
    public static void Main()
    {
        MapCell wall = new MapCell('#');
        
        Map map = new Map(new MapCell[,]
        {
            { null, null, null, null, null, },
            { null, null, null, null, null, },
            { null, wall, wall, null, null, },
            { null, wall, null, null, null, },
            { null, null, null, null, wall, },
            { null, null, null, null, null, },
            { null, null, null, null, null, },
        });

        IMoveBehaviour tryMoveRight = new TryMoveRight(map);
        IMoveBehaviour tryMoveLeft = new TryMoveLeft(map);
        IMoveBehaviour tryMoveDown = new TryMoveDown(map);
        IMoveBehaviour tryMoveUp = new TryMoveUp(map);

        IMoveBehaviour tryMoveVertical = new RandomMoveBehaviour(tryMoveDown, tryMoveUp);
        IMoveBehaviour tryMoveHorizontal = new RandomMoveBehaviour(tryMoveLeft, tryMoveRight);
        
        tryMoveRight.OnFail = tryMoveVertical;
        tryMoveDown.OnFail = tryMoveHorizontal;
        tryMoveLeft.OnFail = tryMoveVertical;
        tryMoveUp.OnFail = tryMoveHorizontal;
        
        UnitMovement unitMovement = new UnitMovement();
        Unit unit = new Unit(unitMovement, tryMoveRight);

        while (true)
        {
            Console.SetCursorPosition(unitMovement.Position.Left, unitMovement.Position.Top);
            Console.Write(" ");

            unit.Move();

            Console.SetCursorPosition(unitMovement.Position.Left, unitMovement.Position.Top);
            Console.Write("@");

            Thread.Sleep(100);
        }
    }
}