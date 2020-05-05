using UnityEngine;
using ink.ScriptableStateMachine;

[CreateAssetMenu(fileName = "DebugAction", menuName = "ScriptableStateMachine/Action/DebugAction", order = 1)]
public class DebugAction : Action
{
    public string debugString;

    public override void DoAction(StateMachine stateMachine)
    {
        Debug.Log(debugString);
    }
}
