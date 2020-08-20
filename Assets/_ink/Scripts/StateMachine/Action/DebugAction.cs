using UnityEngine;
using ink.StateMachine;

public class DebugAction : Action
{
    public string debugString;

    public override void DoAction()
    {
        Debug.Log(debugString);
    }
}
