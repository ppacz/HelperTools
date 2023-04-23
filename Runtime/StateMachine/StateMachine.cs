using UnityEngine;

namespace Unknown.StateMachine
{
    public class StateMachine
    {
        public State CurrentState { get; private set; }
        
        public void initialize(State startState)
        {
            CurrentState = startState;
            CurrentState.Enter();
        }

        public void ChangeState(State newState)
        {
            CurrentState.Exit();
            CurrentState = newState;
            CurrentState.Enter();
        }
    }
}
