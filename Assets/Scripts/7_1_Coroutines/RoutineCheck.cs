using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutineCheck : MonoBehaviour
{
    void Start()
    {
        // 2 ways to call co-routine:
        //StartCoroutine("NameRoutine");   // slower, but have ability to stop the co-routine
        StartCoroutine(NameRoutine());
    }

    // suspend program execution for specified amount of seconds
    IEnumerator NameRoutine()
    {
        yield return new WaitForSeconds(3.0f);
        Debug.Log("Apple Dragon");

        yield return new WaitForSeconds(2.0f);
        Debug.Log("jMacNut");
    }
}
