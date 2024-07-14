using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Code.Services.AssetProvider
{
    public interface IAssetProvider
    {
        void Load();
        UniTask<T> GetPrefabFromAsset<T>(AssetReference assetReference) where T : class;
        UniTask<T> GetPrefabFromAsset<T>(string assetKey) where T : class;
        void Clean();
    }
}