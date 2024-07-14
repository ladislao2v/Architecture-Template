using Code.Services.SceneLoader;
using Plugins.StateMachine.Core.Interfaces;
using UnityEngine;

namespace Code.StateMachine.States
{
    public class BootState : IState
    {
        private readonly IStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;

        public BootState(IStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }
        
        public async void Enter()
        {
            Debug.Log("BootState enter");
        }

        public async void Exit()
        {
            Debug.Log("BootState exit");
        }
    }
}