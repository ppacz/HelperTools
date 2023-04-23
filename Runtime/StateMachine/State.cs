using UnityEngine;

namespace Unknown.StateMachine
{
    public class State
    {
        protected StateMachine stateMachine;
        protected float startTime;

        protected string name;

        public State(StateMachine stateMachine, string name)
        {
            this.stateMachine = stateMachine;
            this.name = name;
        }

        public virtual void Enter()
        {
            this.startTime = Time.time;
            Check();
        }

        public virtual void Exit()
        {

        }

        public virtual void LogicUpdate()
        {

        }

        public virtual void PhysicsUpdate()
        {
            Check();
        }

        public virtual void Check()
        {

        }
    }
}
