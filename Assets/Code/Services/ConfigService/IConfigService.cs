using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Code.Services.ConfigService
{
    public interface IConfigService
    {
        UniTask<T> Get<T>(string assetKey) where T : ScriptableObject;
    }
}