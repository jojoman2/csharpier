class ClassName
{
    void MethodName()
    {
        var newState = (GetState(), action, hasKey) switch
        {
            (DoorState.Closed, Action.Open, _) => DoorState.Opened,
            (DoorState.Opened, Action.Close, _) => DoorState.Closed,
            (DoorState.Closed, Action.Lock, true) => DoorState.Locked,
            (DoorState.Locked, Action.Unlock, true) => DoorState.Closed,
            (var state, _, _) => state
        };
    }
}