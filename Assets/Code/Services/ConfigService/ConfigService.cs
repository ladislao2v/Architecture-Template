using Code.Services.AssetProvider;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services.ConfigService
{
    public class ConfigService : IConfigService
    {
        private readonly IAssetProvider _assetProvider;

        public ConfigService(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public async UniTask<T> Get<T>(string assetKey) where T : ScriptableObject
        {
            return await _assetProvider.GetAsset<T>(assetKey);
        }
    }
}