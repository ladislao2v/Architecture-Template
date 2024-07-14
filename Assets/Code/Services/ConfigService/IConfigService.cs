using UnityEngine;

namespace Code.Services.ConfigService
{
    public interface IConfigService
    {
        void Load<T>(string path) where T : ScriptableObject;
        
        T[] Get<T>() where T : ScriptableObject;
    }
}