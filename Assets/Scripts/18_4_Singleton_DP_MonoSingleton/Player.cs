using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Inheriting MonoSingleton
/// </summary>
namespace Singleton_DP_MonoSingleton_Space
{
    public class Player : MonoSingleton<Player>
    {
        public string playerName;

        // instead of Awake(), use this
        public override void Init()
        {
            base.Init();   // does nothing
            Debug.Log("Player Initialized!");

            LevelManager.Instance.LoadLevel();
        }

        //void Start()
        //{
        //    // removed UIManager from Hierarchy to simulate missing game object
        //    //UIManager.Instance.UpdateScore(42);
        //    SpawnManager.Instance.StartSpawning();
        //}

        //void Update()
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        // UIManager missing, but creates one on the fly!
        //        UIManager.Instance.UpdateScore(42);
        //    }
        //}
    } 
}
