using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton_DP_LazyInstantiation_Space
{
    public class Player : MonoBehaviour
    {
        void Start()
        {
            // removed UIManager from Hierarchy to simulate missing game object
            //UIManager.Instance.UpdateScore(42);
            SpawnManager.Instance.StartSpawning();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // UIManager missing, but creates one on the fly!
                UIManager.Instance.UpdateScore(42);
            }
        }
    } 
}
