using System;
using Plugins.StateMachine.Core.Interfaces;
using Zenject;

namespace Plugins.StateMachine.Core.StateFactory
{
    public class StateFactory : IStateFactory
    {
        private readonly DiContainer _container;

        public StateFactory(DiContainer container) => 
            _container = container;

        public IState Create<TState>() where TState : class, IState => 
            _container.Instantiate<TState>();

        public IState Create(Type type)
        {
            if (typeof(IState).IsAssignableFrom(type) == false)
                throw new ArgumentException(nameof(type));

            return (IState) _container.Instantiate(type);
        }
    }
}