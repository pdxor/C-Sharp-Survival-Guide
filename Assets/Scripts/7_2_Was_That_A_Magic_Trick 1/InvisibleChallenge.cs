using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleChallenge : MonoBehaviour
{
    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("I Key Pressed");
            GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine(HideRoutine());
            // unpredictable behavior if i key us pressed repeatedly
        }
    }

    IEnumerator HideRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        GetComponent<MeshRenderer>().enabled = true;
    }
}
