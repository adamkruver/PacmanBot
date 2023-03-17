using PacmanBot.Common;

namespace PacmanBot.Domain.Unit.Movement;

public class TryMoveLeft : TryMove
{
    public TryMoveLeft(Map.Map map) : base(map, Position.Backward)
    {
    }

    protected override void MakeMove(IMovable movable)
    {
        movable.SetBehaviour(this);
        movable.MakeMove();
    }
}