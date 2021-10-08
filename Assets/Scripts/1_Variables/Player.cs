using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Vairiables
/// Common Data Types
/// </summary>
namespace Variables {
    public class Player : MonoBehaviour
    {
        /// <summary>
        /// Variable Declarations
        ///    Accessor: public (appears in the Inspector) or private reference
        ///    Type: string, char, bool, float, double, int, long, DatTime, etc.
        ///    Name: camel casing
        ///    Initialization (optional): value
        ///    
        /// Best practice is to make all variables private, and expose them with 
        /// [SerializeField] private int number;
        /// 
        /// </summary>

        // common C# data types
        // see https://www.tutorialsteacher.com/csharp/csharp-data-types

        [Header("Player Info")]
        public string playerName = "jmacnut";
        public int playerAge = 33;
        public string myLocation = "Honolulu";

        [Header("Player's Vitals")]
        public int playerHealth = 100;
        public int playerScore = 42;
        public bool playerHasAllKeys = false;

        [Header("Player's Features")]
        public float playerSpeed = 5.5f;
        public int playerAmmoCount = 50;

        // Unity data types - drag desired object into these fields in the Editor
        // see
        [Header("Unity Objects")]
        public GameObject player;
        public Animator playerAnimator;
        public Transform playerTransform;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Player name is " + playerName + " from " + myLocation + " and I am " + playerAge + " years old.");
            Debug.Log("Player Position: " + playerTransform.position.ToString());   // drag Main Camera to Editor
            Debug.Log("Player Health: " + playerHealth);
            Debug.Log("Player Score: " + playerScore);
            Debug.Log("Player Has All Keys: " + playerHasAllKeys);
            Debug.Log("Player Speed: " + playerSpeed);
            Debug.Log("Player Ammo Count: " + playerAmmoCount);
        }
    }
}