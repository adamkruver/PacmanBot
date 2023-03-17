using PacmanBot.Common;

namespace PacmanBot.Domain.Unit.Movement;

public interface IMovable
{
    Position Position { get; }
    void SetBehaviour(IMoveBehaviour behaviour);
    void Move();
    void MakeMove();
}