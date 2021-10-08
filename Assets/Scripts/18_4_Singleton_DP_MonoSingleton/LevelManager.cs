using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton_DP_MonoSingleton_Space
{
    public class LevelManager : MonoSingleton<LevelManager>
    {
        public override void Init()
        {
            base.Init();
            Debug.Log("LevelManager::Init(): Level Manager Initialized!");
        }

        public void LoadLevel()
        {
            Debug.Log("LevelManager::LoadLevel(): Loading Level...");
        }
    } 
}
