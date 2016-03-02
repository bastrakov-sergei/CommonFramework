using CommonLibraries.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class StateComponent : MonoBehaviour, IGenericDictionary<string>
    {          
        private IGenericDictionary<string> stateDictionary = new GenericDictionary<string>();

        public T Get<T>(string key)
        {
            return stateDictionary.Get<T>(key);
        }

        public void Set<T>(string key, T value)
        {
            stateDictionary.Set(key, value);
        }

        public void Clear()
        {
            stateDictionary.Clear();
        }

        public bool Remove(string key)
        {
            return stateDictionary.Remove(key);
        }
    }
}