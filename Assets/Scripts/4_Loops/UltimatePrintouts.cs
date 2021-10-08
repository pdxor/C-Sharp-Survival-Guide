using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Print out 0 to 10, even numbers to 20, then odd numbers to 30
/// Hint: Use modulo operator
/// </summary>

namespace Loops
{
    public class UltimatePrintouts : MonoBehaviour
    {
        private int _max = 30;

        void Start()
        {
            for (int i = 0; i <= _max; i++)
            {
                if (i > 20)
                {
                    if (i % 2 == 1)
                    {
                        Debug.Log(i);
                    }
                }
                else if (i > 10)
                {
                    if (i % 2 == 0)
                    {
                        Debug.Log(i);
                    }
                }
                else if (i >= 0)
                {
                    Debug.Log(i);
                }
            }
        }

        void Update()
        {

        }
    }
}
