using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player communicates with the GameManager
/// </summary>
namespace Singleton_DP_GameManager_Space
{
    public class Player : MonoBehaviour
    {
        // traditional way of accessing GameManager - resource hog
        //private GameManager _gm;

        void Start()
        {
            // traditional way of accessing GameManager - resource hog
            //_gm = GameObject.Find("Game_Manager").GetComponent<GameManager>();

            // instead, use a Singleton
            GameManager.Instance.DisplayName();
        }

        void Update()
        {

        }
    } 
}
