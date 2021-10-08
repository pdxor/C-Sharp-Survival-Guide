using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace LINQ_Examples_Space
{
    public class LinqExamples : MonoBehaviour
    {
        [SerializeField] private string[] names1 = { "jmacnut", "alex", "julie", "jessie", "david", "mark", "matt" };
        [SerializeField] private string[] names2 = { "alex", "jmacnut", "alex", "julie", "julie", "jessie", "david", "mark", "jmacnut", "matt" };
        [SerializeField] private string[] names3 = { "jmacnut", "alex", "julie", "jessie", "david", "mark", "matt", "bautista" };

        private int[] _quizGrades = { 44, 55, 32, 77, 95, 99, 88 };

        void Start()
        {
            //TraditionalSearch("jmacnut");

            // LINQ using lambda operator/function - boolean
            var nameFound1 = names1.Any(name => name == "jmacnut");
            Debug.Log("Name Found (lambda): " + nameFound1);

            // LINQ Contains - determines if an item is present in the collection
            var nameFound2 = names1.Contains("jmacnut");
            Debug.Log("Name Found (method): " + nameFound2);

            // LINQ Distinct - Removes duplicates and returns unique list
            var uniqueNames = names2.Distinct();

            foreach (var name in uniqueNames)
            {
                Debug.Log("Unique Name: " + name);
            }

            // LINQ Where - creates a new collection based on a condition
            // Ex. names with more than 5 characters
            var results = names3.Where(n => n.Length > 5);

            // may need to reset the list in the Inspector
            foreach (var name in results)
            {
                Debug.Log("Name (Conditional Where): " + name);
            }

            // LINQ - Order by Descending
            //GenerateRandomQuizGrades();
            var passingGrades = _quizGrades.Where(qg => qg > 69).OrderByDescending(g => g);
            //var passingGrades = _quizGrades.Where(qg => qg > 69).OrderByDescending(g => g).Reverse();

            foreach (var grade in passingGrades)
            {
                Debug.Log("Ordered Passing Grade: " + grade);
            }

            foreach (var grade in passingGrades.Reverse())
            {
                Debug.Log("Reverse Ordered Passing Grade: " + grade);
            }

            // LINQ - Filter Items

        }

        void TraditionalSearch(string person)
        {
            foreach (var name in names1)
            {
                if (name == person)
                {
                    Debug.Log("Found: " + name);
                }
                else
                {
                    //Debug.Log("Not: " + name);
                }
            }
        }
    }
}

