using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Change the cube to a random color every 3 seconds
/// </summary>
public class TimedRandomColorChange : MonoBehaviour
{
    private MeshRenderer _render;
    private WaitForSeconds _colorChangeWait = new WaitForSeconds(3.0f);

    //void Start()
    //{
    //    _colorChangeWait = new WaitForSeconds(3.0f);
    //    _render = GetComponent<MeshRenderer>();
    //    StartCoroutine(RandomColorChangeRoutine());
    //}

    //IEnumerator Start()
    //{
    //    _colorChangeWait = new WaitForSeconds(3.0f);
    //    _render = GetComponent<MeshRenderer>();
    //    yield return null;   // waits 1 frame
    //    StartCoroutine(RandomColorChangeRoutine());
    //}

    // chained coroutine!
    IEnumerator Start()
    {
        _colorChangeWait = new WaitForSeconds(3.0f);
        _render = GetComponent<MeshRenderer>();
        yield return StartCoroutine(RandomColorChangeRoutine());
    }

    IEnumerator RandomColorChangeRoutine()
    {
        while (true)
        {
            //yield return new WaitForSeconds(3.0f);
            yield return _colorChangeWait;   // removes new for optimization
            _render.material.color = NewRandomColor();
        }
    }

    Color NewRandomColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        return randomColor;
    }
}
