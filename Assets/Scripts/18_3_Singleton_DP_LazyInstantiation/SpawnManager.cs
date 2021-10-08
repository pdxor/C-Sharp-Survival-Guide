using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SpawnManager Singleton
/// - Using lazy instantiation
/// - Caution: Won't auto-populate Inspector information, i.e., SpawnManager Instantiate prefabs
/// </summary>
namespace Singleton_DP_LazyInstantiation_Space
{
    public class SpawnManager : MonoBehaviour
    {
        // create the instance property
        private static SpawnManager _instance;
        public static SpawnManager Instance
        {
            get
            {
                // error handler if _instance is null
                if(_instance == null)
                {
                    Debug.LogError("SpawnManager::Instance: The Spawn Manager instance is NULL");
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
            _instance = this;
        }

        public void StartSpawning()
        {
            Debug.Log("SpawnManager::StartSpawning: Start Spawning!");
        }
    } 
}
