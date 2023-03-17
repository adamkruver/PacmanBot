using PacmanBot.Common;
using PacmanBot.Domain.Unit.Behaviuor;

namespace PacmanBot.Domain.Unit.Movement;

public interface IMoveBehaviour: IBehaviour<IMovable>
{
    Position Direction { get; } 
}