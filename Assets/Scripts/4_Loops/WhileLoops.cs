using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// While Loops:
/// - Executes while a condition is true and exits when the condition is false
/// - Often used with IEnumerator
/// 
/// Use cases:
/// - Infinite Loop can provide a sleep feature
/// </summary>

public class WhileLoops : MonoBehaviour
{
    private int _apples;

    void Start()
    {
        while (_apples < 50)
        {
            Debug.Log("We love apples!");
            _apples++;
        }

        StartCoroutine(LoopRoutine());
    }

    void Update()
    {
        
    }

    IEnumerator LoopRoutine()
    {
        // runs forever every second (infinite loop)
        // if this runs directly in start(), application will fill memory and crash
        while (true)
        {
            yield return new WaitForSeconds(1.0f);

            // spawn and enemy every second
            Debug.LogError("Spawning Enemy Every Second");
        }
    }
}
