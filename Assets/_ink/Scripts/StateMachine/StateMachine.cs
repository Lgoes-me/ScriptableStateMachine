using UnityEngine;

namespace ink.StateMachine
{
    public class StateMachine : MonoBehaviour
    {
        public State initialState;

        private State _currentState;
        private State[] _states;

        private void Awake()
        {
            _states = GetComponents<State>();

            foreach (State state in _states)
            {
                state.Init(this);
            }

            SetState(initialState);
        }

        public void SetState(State state)
        {
            if (state == _currentState)
                return;

            _currentState?.OnExit();

            _currentState = state;

            _currentState.OnEnter();
        }

        private void Update()
        {
            _currentState?.OnUpdate();
        }
    }
}