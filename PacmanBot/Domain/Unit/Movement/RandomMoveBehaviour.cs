using PacmanBot.Common;
using PacmanBot.Domain.Unit.Behaviuor;

namespace PacmanBot.Domain.Unit.Movement;

public class RandomMoveBehaviour : IMoveBehaviour
{
    public RandomMoveBehaviour(IMoveBehaviour firstBehaviour, IMoveBehaviour secondBehaviour)
    {
        OnSuccess = firstBehaviour;
        OnFail = secondBehaviour;
    }

    public IBehaviour<IMovable>? OnSuccess { get; set; }
    public IBehaviour<IMovable>? OnFail { get; set; }
    public Position Direction { get; } = Position.Zero;
    
    public void Handle(IMovable movable)
    {
        Random random = new Random();
        
        if (random.Next(2) == 0)
            OnSuccess?.Handle(movable);
        else
            OnFail?.Handle(movable);
    }
}