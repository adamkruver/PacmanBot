using PacmanBot.Common;

namespace PacmanBot.Domain.Unit.Movement;

public class TryMoveUp : TryMove
{
    public TryMoveUp(Map.Map map) : base(map, Position.Up)
    {
    }

    protected override void MakeMove(IMovable movable)
    {
        movable.SetBehaviour(this);
        movable.MakeMove();
    }
}