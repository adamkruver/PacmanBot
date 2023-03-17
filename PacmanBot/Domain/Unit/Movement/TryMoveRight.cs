using PacmanBot.Common;

namespace PacmanBot.Domain.Unit.Movement;

public class TryMoveRight : TryMove
{
    public TryMoveRight(Map.Map map) : base(map, Position.Forward)
    {
    }

    protected override void MakeMove(IMovable movable)
    {
        movable.SetBehaviour(this);
        movable.MakeMove();
    }
}