using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Singleton
/// - Global access to a class that only exists once (static)
/// - Useful for manager type classes
/// - SpawnManager, GameManager, UIManager, AudioManager, PlayerManager, ItemManager, etc.
/// - Access directly, instead of via GetComponent<>() which can take up additional resources
/// - 
/// - 
/// </summary>
namespace Singleton_DP_UIManager_Space
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        public static GameManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    Debug.LogError("The Game Manager is NULL");
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
            // initialize singleton to the object this script is attached to
            _instance = this;
        }

        public void DisplayName()
        {
            Debug.Log("GameManager::DisplayName(): This is the Singleton GameManager Static Class");
        }
    } 
}
