using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Challenge: Create two auto properties
/// - Speed (read-only)
/// - Name (public)
/// </summary>
namespace PropertiesChallengeSpace
{
    public class GameManager : MonoBehaviour
    {
        // PROPERTIES
        //private float _speed;
        //public float Speed
        //{
        //    get
        //    {
        //        return _speed;
        //    }
        //    private set
        //    {
        //        _speed = value;
        //    }
        //}

        // AUTO PROPERTIES
        // public float Speed { get; private set; }
        // or
        public float Speed { get; }

        public string Name { get; set; }

        void Start()
        {
            Debug.Log("Speed = " + Speed);
        }
    } 

    public class TestGameManager
    {
        GameManager gm = new GameManager();

        public TestGameManager()
        {
            //gm.Speed = 5f; // cannot!
            Debug.Log("Speed is " + gm.Speed );  // read-only, ok
            Debug.Log("Name is " + gm.name);
        }
    }
}
