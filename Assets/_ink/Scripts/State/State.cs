using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ink.ScriptableStateMachine
{
    [CreateAssetMenu(fileName = "State", menuName = "ScriptableStateMachine/State", order = 1)]
    public class State : ScriptableObject
    {
        public List<Transition> transitions;

        public UnityEvent OnEnterEvent, OnExitEvent;
        public Action OnUpdateAction;

        private StateMachine _stateMachine;

        public virtual void Init(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;

            foreach(Transition transition in transitions)
            {
                transition.Init(stateMachine);
            }
        }

        public virtual void OnEnter()
        {
            OnEnterEvent.Invoke();
        }

        public virtual void OnUpdate()
        {
            OnUpdateAction?.DoAction(_stateMachine);
        }

        public virtual void OnExit()
        {
            OnExitEvent.Invoke();
        }
    }
}