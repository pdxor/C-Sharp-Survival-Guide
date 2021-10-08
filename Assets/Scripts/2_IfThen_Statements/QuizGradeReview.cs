using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Conditionals
{
    /// <summary>
    /// Objective:
    /// - Calculate the average of 5 quiz grades
    /// - Determine the letter grade based on the following
    ///      Print 'A' >= 90
    ///      Print 'B' >= 80 and < 90
    ///      Print 'C' >= 70 and < 80
    ///      Print 'D' >= 60 and < 70
    ///      Print 'F' < 60
    /// </summary>

    public class QuizGradeReview : MonoBehaviour
    {
        [SerializeField]
        private float _quiz1, _quiz2, _quiz3, _quiz4, _quiz5;
        [SerializeField]
        private float _averageGrade = 0.0f;

        // Start is called before the first frame update
        void Start()
        {
            _quiz1 = Random.Range(0, 101);
            _quiz2 = Random.Range(0, 101);
            _quiz3 = Random.Range(0, 101);
            _quiz4 = Random.Range(0, 101);
            _quiz5 = Random.Range(0, 101);

            _averageGrade = (_quiz1 + _quiz2 + _quiz3 + _quiz4 + _quiz5) / 5;

            if(_averageGrade >= 90)
            {
                Debug.Log("Grade: A");
            }
            else if(_averageGrade >= 80)
            {
                Debug.Log("Grade: B");
            } 
            else if(_averageGrade >= 70)
            {
                Debug.Log("Grade: C");
            }
            else if(_averageGrade >= 60)
            {
                Debug.Log("Grade: D");
            }
            else
            {
                Debug.Log("Grade: F");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}