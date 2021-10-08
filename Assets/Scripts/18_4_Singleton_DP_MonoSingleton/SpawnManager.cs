using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SpawnManager Singleton
/// - Utilizing the Player MonoSingleton
/// </summary>
namespace Singleton_DP_MonoSingleton_Space
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
        private void Start()
        {
            // Using the Player MonoSingleton
            Debug.Log("SpawnManager::Start(): Player's Name: " + Player.Instance.playerName);
        }

        public void StartSpawning()
        {
            Debug.Log("SpawnManager::StartSpawning: Start Spawning!");
        }
    } 
}
