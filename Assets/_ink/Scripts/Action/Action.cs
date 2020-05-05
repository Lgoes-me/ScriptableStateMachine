using UnityEngine;

namespace ink.ScriptableStateMachine
{
    //[CreateAssetMenu(fileName = "Action", menuName = "ScriptableStateMachine/Action", order = 1)]
    public abstract class Action : ScriptableObject
    {
        public abstract void DoAction(StateMachine stateMachine);
    }
}