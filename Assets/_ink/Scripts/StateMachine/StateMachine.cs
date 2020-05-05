using System.Collections.Generic;
using UnityEngine;

namespace ink.ScriptableStateMachine
{
    public class StateMachine : MonoBehaviour
    {
        public State _currentState;
        public List<State> states;

        private void Awake()
        {
            _currentState.Init(this);

            foreach (State state in states)
            {
                state.Init(this);
            }
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