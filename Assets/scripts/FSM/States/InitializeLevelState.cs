using System.Collections.Generic;
using UnityEngine;

namespace Assets.scripts.FSM.States
{
    internal class InitializeLevelState : ILevelState
    {
        private LevelStateMachine _levelStateMachine;

        public InitializeLevelState(LevelStateMachine levelStateMachine)
        {
            _levelStateMachine = levelStateMachine;
        }

        public void Enter()
        {
            Debug.Log("Enter initialize");
        }

        public void Exit()
        {
            Debug.Log("Exit initialize");
        }
    }
}
