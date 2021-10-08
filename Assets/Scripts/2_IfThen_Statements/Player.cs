using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Challenge P01: Add 10 points if the space key is pressed
///     Uses Input.GetKeyDown(KeyCode.Space) and +=
/// Challenge P02: Print a notification once 50 points is reached
/// Challenge P03: Print the message fromn P02 only once
///     Boolean flag
///     Compound conditions with &&
/// Select Difficulty with If..Else If..Else Statements
/// Challenge P04: 

/// 
/// </summary>
namespace Conditionals
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private int _points = 0;
        [SerializeField]
        private bool _messagePosted = false;

        // difficulty level
        [SerializeField]
        private int _easy = 1;
        [SerializeField]
        private int _medium = 2;
        [SerializeField]
        private int _hard = 3;
        [SerializeField]
        private int _difficulty;
        [SerializeField]
        private bool _selectionPosted;

        // Start is called before the first frame update
        void Start()
        {
            _difficulty = _easy; 
            _selectionPosted = false;
        }

        // Update is called once per frame
        void Update()
        {
            // ToDo: to print out only once, add logic to check if _difficulty was changed

            // select level of difficulty
            if ((_difficulty == _easy) && (_selectionPosted == false))
            {
                Debug.Log("Difficulty: EASY");
            }
            else if ((_difficulty == _medium) && (_selectionPosted == false))
            {
                Debug.Log("Difficulty: MEDIUM");
            } else if ((_difficulty == _hard) && (_selectionPosted == false))
            {
                Debug.Log("Difficulty: HARD");
            } else
            {
                Debug.Log("Invalid Difficulty Level");
                //_selectionPosted = false;
            }

            // if we hit the space key
            // add 10 points
            if (Input.GetKeyDown(KeyCode.Space)) {
                _points += 10;
            }

            // if greater than or equal to 50 points
            // print message, but only once!
            if ((_points >= 50) && (_messagePosted == false))
            {
                Debug.Log("Awesome Sauce! " + _points + "Points");
                _messagePosted = true;
            }

        }
    }
}
