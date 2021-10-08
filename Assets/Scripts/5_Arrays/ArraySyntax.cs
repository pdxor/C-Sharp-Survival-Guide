using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Array Syntax:
/// 3 ways to declare an array and accessing their elements
/// </summary>

namespace Arrays
{
    public class ArraySyntax : MonoBehaviour
    {
        // 1 - declare array size and elements in the Inspector (most common)
        // note: save project for Inspector elements to persist
        public string[] names;

        // 2 - initialize the array size in the declaration
        // note: save project for Inspector elements to persist
        public string[] items = new string[5];

        // 3 - declare and initialize the array elements
        // note: these items persists since they are hard coded
        public int[] ages = { 5, 5, 3, 2, 55, 66};

        void Start()
        {
            // accessing array elements
            Debug.Log(names[1]);   // "Bz"
            Debug.Log(items[1]);   // "bread"
            Debug.Log(ages[4]);    // 55
        }

        void Update()
        {

        }
    }
}
