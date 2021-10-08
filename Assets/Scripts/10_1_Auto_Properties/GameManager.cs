using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// AUTO PROPERTIES
/// - Property Shortcut
/// - Specify access modifiers (private)
/// - Cannot run any additional code
/// - Unity cannot show properties in the Inspector (Use Debug Mode or Custom Editor)
/// </summary>
namespace AutoPropertiesSpace
{

    // create a game state to check to see if the game is over
    public class GameManager : MonoBehaviour
    {
        // PROPERTIES
        //private bool isGameOver;   // read-only private attribute (camel case)

        //// Property Declaration - public accessor to private read-only attribute (Pascal Case)
        //public bool IsGameOver
        //{
        //    get
        //    {
        //        return isGameOver;
        //    }
        //}

        // AUTO PROPERTY
        public bool IsGameOver { get; private set; }   // shortcut, but cannot run logic specific code
                                                       // private - can only get, but not set the var from outside of this class
                                                       // protected - accessible by class that inherits from this class



        // Start is called before the first frame update
        void Start()
        {
            IsGameOver = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //IsGameOver = true;
            }
        }

        public void GameOver()
        {
            // Call UI Manager and enable the game over screen
        }
    } 
}
