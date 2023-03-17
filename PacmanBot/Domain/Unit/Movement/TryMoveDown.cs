using PacmanBot.Common;

namespace PacmanBot.Domain.Unit.Movement;

public class TryMoveDown : TryMove
{
    public TryMoveDown(Map.Map map) : base(map, Position.Down)
    {
    }

    protected override void MakeMove(IMovable movable)
    {
        movable.SetBehaviour(this);
        movable.MakeMove();
    }
}