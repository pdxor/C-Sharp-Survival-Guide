using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Do..While Loop: 
/// Runs at least once, unconditionally 
/// - executes while the condition is false, 
/// - and terminates when condition is true
/// 
/// Use cases: Rare
/// </summary>
public class DoWhileLoops : MonoBehaviour
{
    [SerializeField]
    private int _apples;

    void Start()
    {
        do
        {
            // index incrementer provides a way to satisty the exit condition
            // note: otherwise, infinite loop
            _apples++;

            // statement code
            Debug.Log("My name is jmacnut");

        } while (_apples < 5);
    }

    void Update()
    {
        
    }
}
