using System.Numerics;
using PacmanBot.Common;
using PacmanBot.Domain.Unit.Movement;

namespace PacmanBot.Domain.Unit;

public class Unit : IMovable
{
    private readonly IMovable _mover;

    public Unit(IMovable mover, IMoveBehaviour startBehaviour)
    {
        _mover = mover;
        SetBehaviour(startBehaviour);
    }

    public Position Position => _mover.Position;

    public void SetBehaviour(IMoveBehaviour behaviour) => 
        _mover.SetBehaviour(behaviour);

    public void Move() =>
        _mover.Move();

    public void MakeMove() =>
        _mover.MakeMove();
}