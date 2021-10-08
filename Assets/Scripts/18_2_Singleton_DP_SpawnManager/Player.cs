using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton_DP_SpawnManager_Space
{
    public class Player : MonoBehaviour
    {
        void Start()
        {
            UIManager.Instance.UpdateScore(42);
            SpawnManager.Instance.StartSpawning();
        }

        void Update()
        {

        }
    } 
}
