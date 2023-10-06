using UnityEngine;

namespace Assets.scripts.FSM.States
{
    internal class LoadingLevelState : ILevelState
    {
        private LevelStateMachine _levelStateMachine;

        public LoadingLevelState(LevelStateMachine levelStateMachine)
        {
            _levelStateMachine = levelStateMachine;
        }

        public void Enter()
        {
            Debug.Log("Enter loading");

            var playerObject =  Resources.Load(GameConstants.PLAYER_PATH);
            Object.Instantiate(playerObject, new Vector3(0,0,13), Quaternion.identity);

            _levelStateMachine.EnterIn<InitializeLevelState>();
        }

        public void Exit()
        {
            Debug.Log("Exit loading");

        }
    }
}
