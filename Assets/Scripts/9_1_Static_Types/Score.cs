using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaticSpace
{
    // Class or Static Variables and Methods
    // exists for the life of the program, even if this object is destroyed
    // static variable and methods are shared among all instances of an object
    public class Score : MonoBehaviour
    {
        //public int score;   // (2) access via script communication

        public static int score;   // cannot see static vars in the Inspector

        public static int AddScore(int scoreAmount)
        {
            return score += scoreAmount;
        }
    } 
}
