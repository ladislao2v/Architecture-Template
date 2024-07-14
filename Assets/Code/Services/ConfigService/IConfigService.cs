using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services.ConfigService
{
    public interface IConfigService
    {
        void Load<T>(string path) where T : ScriptableObject;
        
        T[] Get<T>();
    }

    public class ResourceConfigService : IConfigService
    {
        public void Load<T>(string path) where T : ScriptableObject
        {
            T[] configs = Resources.LoadAll<T>(path);
        }

        public T[] Get<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}