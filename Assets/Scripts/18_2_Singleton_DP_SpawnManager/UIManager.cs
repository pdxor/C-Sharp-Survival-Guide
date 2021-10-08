using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton_DP_SpawnManager_Space
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
                    Debug.LogError("UIManager::Instance: The Game Manager instance is NULL");
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
