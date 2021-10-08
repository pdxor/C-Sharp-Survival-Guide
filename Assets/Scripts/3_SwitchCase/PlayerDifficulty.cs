using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Print the player's difficulty selection.
/// </summary>
namespace SwitchCase
{
    public class PlayerDifficulty : MonoBehaviour
    {
        [SerializeField]
        private int _difficulty;

        // Start is called before the first frame update
        void Start()
        {
            _difficulty = 1; 
        }

        // Update is called once per frame
        void Update()
        {
            // ToDo: to print out only once, add logic to check if _difficulty was changed

            // select level of difficulty
            switch(_difficulty)
            {
                case 1:   // _easy
                    Debug.Log("Difficulty: EASY");
                    break;
                case 2:   // _medium
                    Debug.Log("Difficulty: MEDIUM");
                    break;
                case 3:   // _hard
                    Debug.Log("Difficulty: HARD");
                    break;
                default:
                    Debug.Log("Invalid Difficulty Level");
                    break;
            }
        }
    }
}
