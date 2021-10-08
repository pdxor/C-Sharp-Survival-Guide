using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Observer Design Pattern
/// - Use Delegates & Events
/// - Using System namespace
/// - Action
/// 
/// </summary>
namespace Observer_DP_Space
{
    public class Player : MonoBehaviour
    {
        //[SerializeField] private List<MeshRenderer> _meshRenderers;

        // declare an event
        public static event Action onTurnRed;


        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // decouple
                // who cares that the space key was pressed?
                // raise some event
                onTurnRed?.Invoke();


                // must know ahead of time how many cubes exist 
                // (must be dragged into Inspector)
                //foreach (var cube in _meshRenderers)
                //{
                //    cube.material.color = Color.red;
                //}
            }
        }
    } 
}
