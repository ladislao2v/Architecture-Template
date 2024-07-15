using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Code.Services.SceneLoader
{
    public class SceneLoader : ISceneLoader
    {
        public async UniTask LoadScene(string name, Action onLoaded = null)
        {
            AsyncOperationHandle<SceneInstance> handle = Addressables.LoadSceneAsync(name);

            handle.Completed += _ => onLoaded?.Invoke();

            await handle;
        }

        public async UniTask RestartScene(Action onLoaded = null)
        {
            Scene scene = SceneManager.GetActiveScene();

            await SceneManager.LoadSceneAsync(scene.name);
            
            onLoaded?.Invoke();
        }
    }
}