using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Convert SQL Syntax (Query Select) to Method Syntax
/// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
/// </summary>
namespace ConvertSQL2MethodSyntax_Space
{
    public class ConvertSQL2MethodSyntax : MonoBehaviour
    {
        // data source
        int[] scores = new int[] { 97, 92, 81, 60 };

        private void Start()
        {
            // SQL query expression
            IEnumerable<int> scoreQuerySyntax =
                from score in scores
                where score > 80
                select score;

            foreach (int score in scoreQuerySyntax)
            {
                Debug.Log("SQL Score: " + score);
            }

            // Method Syntax
            var scoreQueryMethod = scores.Where(score => score > 80);

            foreach (var score in scoreQueryMethod)
            {
                Debug.Log("Method Score: " + score);
            }

        }
    } 
}
