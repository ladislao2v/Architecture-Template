using System;
using Plugins.StateMachine.Core.Interfaces;

namespace Plugins.StateMachine.Core.StateFactory
{
    public interface IStateFactory
    {
        IState Create<TState>() where TState : class, IState;
        IState Create(Type type);
    }
}