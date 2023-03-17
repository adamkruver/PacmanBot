using PacmanBot.Common;

namespace PacmanBot.Domain.Unit.Movement;

public class UnitMovement : IMovable
{
    private IMoveBehaviour _behaviour;
    
    public Position Position { get; private set; } = Position.Zero;

    public void SetBehaviour(IMoveBehaviour behaviour) => 
        _behaviour = behaviour;

    public void Move() =>
        _behaviour.Handle(this);

    public void MakeMove() =>
        Position += _behaviour.Direction;
}