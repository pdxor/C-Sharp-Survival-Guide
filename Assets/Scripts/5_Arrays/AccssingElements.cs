using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Access element sets randomly
/// </summary>

namespace Arrays
{
    public class AccssingElements : MonoBehaviour
    {
        public string[] names;
        public string[] cars;
        public int[] ages;

        private int _randomId;

        void Start()
        {
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _randomId = Random.Range(0, names.Length);
                Debug.LogError("Random ID: " + _randomId);

                Debug.Log("Name: " + names[_randomId] + " Age: " + ages[_randomId] + " Car: " + cars[_randomId]);
            }
        }
    }
}
