using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generic Template for all Singleton Manager type classes using the Generic type T
/// Recommended use is every project
/// See Player manager and LevelManager inherits MonoSingleton and SpawnManager calling Player MonoSingleton
/// </summary>
namespace Singleton_DP_MonoSingleton_Space
{
    // cannot attach abstract (template) class, but other classes can inherit this class to access the properties
    public abstract class MonoSingleton<T> : MonoBehaviour where T: MonoSingleton<T>
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError("MonoSingleton::Instance: " + typeof(T).ToString() + " MonoSingleton instance is NULL");
                    return null;
                }
                else
                {
                    return _instance;
                }
            }
        }

        private void Awake()
        {
            _instance = (T)this;    // cast
            //_instance = this as T;  // same as above

            Init();  // if not overidden, will do nothing
        }

        public virtual void Init()
        {
            // optional to override
        }
    } 
}
