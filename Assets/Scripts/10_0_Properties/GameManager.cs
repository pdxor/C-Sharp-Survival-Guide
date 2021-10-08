using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Declaring and Using PROPERTIES ("Smart Variables"):
/// Initialize and assign attributes with...
/// - Accessors: Getters and Setters
/// - Access Control Modifiers
/// - Unity cannot show properties in the Inspector (Use Debug Mode or Custom Editor)
///   Therefore, best used in manager classes (GameManager, SpawnManager, etc.) - no need to adjust in Inspector
///   - Ex. GameManager: IsGameOver, IsDead, Score
///   - Ex. NumEnemies
/// - Must initialize in Start()

/// // we are able to retrieve due to the Get property
/// var position = transform.position;

/// // we are able to assign, due to the Set property
/// transform.position = new Vector3(0, 0, 0);

/// // we are able to read only due to the access modifier
///var date = Time.deltaTime;

/// </summary>
namespace PropertiesSpace
{
    // create a game state to check to see if the game is over
    public class GameManager : MonoBehaviour
    {
        // public bool isGameOver;   // poor practice
        //public bool isGameOver;

        // PROPERTIES
        private bool isGameOver;   // read-only private attribute (camel case)

        // Property Declaration - public accessor to private read-only attribute (Pascal Case)
        public bool IsGameOver
        {
            get
            {
                return isGameOver;
            }
            set
            {
                if (isGameOver == true)
                {
                    Debug.LogError("The Game is Over!!");
                }
                isGameOver = value;   // value assumes assigned when called
            }
        }



        // Start is called before the first frame update
        void Start()
        {
            isGameOver = false;   // only place we would directly assign value (initializer)
            //IsGameOver   // see get; and set; options
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                IsGameOver = true;
            }
        }

        public void GameOver()
        {
            //isGameOver = true;   // poor practice

            // Call UI Manager and enable the game over screen
        }
    } 
}
