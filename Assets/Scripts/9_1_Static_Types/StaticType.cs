using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StaticSpace
{
    public class StaticType : MonoBehaviour
    {
        //[SerializeField] private int _score;   // (1) direct access

        //[SerializeField] private Score _score;   // (2) access via script communication

        void Start()
        {
            //_score = GameObject.Find("Score Keeper").GetComponent<Score>();   // (2) access via script communication
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // add 10 to score
                //_score += 10;   // (1) direct access

                // _score.score += 10;   // (2) access via script communication

                //Score.score += 10;   // (3) access static or class variable, directly
                Score.AddScore(10);   // (3) access static method, directly

                // (3) cannot see static vars in the Inspector
                Debug.Log("Score = " + Score.score);
            }
        }
    } 
}
