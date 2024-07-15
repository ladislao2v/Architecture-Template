using System;
using Cysharp.Threading.Tasks;

namespace Code.Services.SceneLoader
{
    public interface ISceneLoader
    {
        UniTask LoadScene(string name, Action onLoaded = null);
        UniTask RestartScene(Action onLoaded = null);
    }
}