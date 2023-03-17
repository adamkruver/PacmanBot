using PacmanBot.Common;
using PacmanBot.Domain.Map;

namespace PacmanBot.Domain.Unit.Movement;

public abstract class TryMove: MoveBehaviour
{
    private readonly Map.Map _map;

    public TryMove(Map.Map map, Position direction) : base(direction) => 
        _map = map;

    protected sealed override bool TryHandle(IMovable movable)
    {
        if (_map.TryGetCell(movable.Position + Direction, out MapCell mapCell) == false)
            return false;

        if (mapCell != null)
            return false;

        MakeMove(movable);
        return true;
    }

    protected abstract void MakeMove(IMovable movable);
}