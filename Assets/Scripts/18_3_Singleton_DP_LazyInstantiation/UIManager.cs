using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UIManager does not exist, use lazy instantiation
/// Caution: Won't auto-populate Inspector information, i.e., SpawnManager Instantiate prefabs
/// </summary>
namespace Singleton_DP_LazyInstantiation_Space
{
    public class UIManager : MonoBehaviour
    {
        // declare a private variable for the instance of this class
        // must be static because it must be unique
        private static UIManager _instance;

        // declare a public accessor property to this class
        public static UIManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    Debug.LogError("UIManager::Instance: The Game Manager instance is NULL, creating one...");
                    GameObject go = new GameObject("UI_Manager");   // create the UI_Manager object
                    go.AddComponent<UIManager>();                   // add UIManager component to the game object
                }
                return _instance;
            }
        }

        private void Awake()
        {
            // assigns to the GameObject this script is attached to
            _instance = this;
        }

        public void UpdateScore(int score)
        {
            Debug.Log("UIManager::UpdateScore(): Score: " + score);
            Debug.Log("UIManager::UpdateScore(): Notifying the Game Manager");
            GameManager.Instance.DisplayName();
        }
    } 
}
