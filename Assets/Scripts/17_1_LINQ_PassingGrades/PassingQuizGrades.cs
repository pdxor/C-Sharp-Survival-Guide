using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// LINQ Challenge 1:
/// - Create an integer array of quiz grades
/// - Grades are between 0 and 100, inclusive
/// - Filter array for only passing grades (> 69)
/// </summary>
namespace LINQ_PassingQuizGrades_Space
{
    public class PassingQuizGrades : MonoBehaviour
    {
        //[SerializeField] private int[] _quizGrades;
        private int[] _quizGrades = { 44, 55, 32, 77, 95, 99, 88 };
        //[SerializeField] private int _numOfQuizzes;

        void Start()
        {
            //_quizGrades = new int[_numOfQuizzes];
            //GenerateRandomQuizGrades();
            var passingGrades = _quizGrades.Where(qg => qg > 69);

            foreach (var passingGrade in passingGrades)
            {
                Debug.Log("Passing Grade: " + passingGrade);
            }

        }
    } 
}
