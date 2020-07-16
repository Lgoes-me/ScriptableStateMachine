using UnityEngine;
using ScriptableObjectArchitecture;

namespace ink.StateMachine
{
    [System.Serializable]
    public class Transition : IGameEventListener
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
