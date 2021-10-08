using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A program that increments the number of apples using coroutines to slow down time
/// </summary>

namespace Loops
{
    public class CoRoutine : MonoBehaviour
    {
        [SerializeField]
        private int _apples;

        void Start()
        {
            StartCoroutine(AddApplesRoutine());
        }

        void Update()
        {

        }

        // Yields time to observe loop execution
        IEnumerator AddApplesRoutine()
        {
            for (int i = 0; i < 100; i++)
            {
                _apples++;
                yield return new WaitForSeconds(0.5f);
            }
        }
    }

    
}
