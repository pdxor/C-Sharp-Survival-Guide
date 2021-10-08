using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simply register and unregister the events
/// </summary>
namespace Observer_DP_Space
{
    public class Cube : MonoBehaviour
    {
        private Material _mesh;   // cache

        private void OnEnable()
        {
            _mesh = GetComponent<MeshRenderer>().material;

            // register to events
            Player.onTurnRed += Player_onTurnRed;
        }

        private void Player_onTurnRed()
        {
            //throw new System.NotImplementedException();
            _mesh.color = Color.red;
        }

        private void OnDisable()
        {
            // unregister to events
            Player.onTurnRed -= Player_onTurnRed;
        }
    } 
}
