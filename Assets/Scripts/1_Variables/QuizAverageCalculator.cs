using System.Collections;
using UnityEngine;

/// <summary>
/// Calculate the average of 5 quiz grades
/// - Random.Range(min, max)
/// - Mathf.Round(val * 100) / 100  // divide by 100 provides 2 decimal places
/// </summary>
namespace Variables {
    public class QuizAverageCalculator : MonoBehaviour
    {
        public float grade1, grade2, grade3, grade4, grade5;
        public float averageGrade = 0.0f;

        void Start()
        {
            grade1 = Random.Range(0.0f, 100.00f);
            grade2 = Random.Range(0.0f, 100.00f);
            grade3 = Random.Range(0.0f, 100.00f);
            grade4 = Random.Range(0.0f, 100.00f);
            grade5 = Random.Range(0.0f, 100.00f);
            averageGrade = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            averageGrade = Mathf.Round(averageGrade * 100) / 100;
            Debug.Log("The Quiz Grade Average = " + averageGrade);
        }
    }
}