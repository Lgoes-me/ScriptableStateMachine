using UnityEngine;
using ScriptableObjectArchitecture;

namespace ink.ScriptableStateMachine
{
    [CreateAssetMenu(fileName = "Transition", menuName = "ScriptableStateMachine/Transition", order = 1)]
    public class Transition : ScriptableObject, IGameEventListener
    {
        public State destinationState;
        public GameEventBase stateChangeEvent;

        private StateMachine _stateMachine;

        public virtual void Init(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
            stateChangeEvent.AddListener(this);
        }

        public void OnEventRaised()
        {
            _stateMachine?.SetState(destinationState);
        }
    }
}
