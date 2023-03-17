using PacmanBot.Common;
using PacmanBot.Domain.Unit.Behaviuor;

namespace PacmanBot.Domain.Unit.Movement;

public abstract class MoveBehaviour : IMoveBehaviour
{
    protected MoveBehaviour(Position direction)
    {
        Direction = direction;
    }

    public IBehaviour<IMovable>? OnSuccess { get; set; }
    public IBehaviour<IMovable>? OnFail { get; set; }
    public Position Direction { get; }
    
    public void Handle(IMovable movable)
    {
        if (TryHandle(movable))
            OnSuccess?.Handle(movable);
        else
            OnFail?.Handle(movable);
    }

    protected abstract bool TryHandle(IMovable movable);
    
}