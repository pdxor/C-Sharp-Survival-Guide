using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticalEventDrivenSpace
{
    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            Player.onDeath += ResetPlayer;

        }

        // matches signature for onDeath()
        public void ResetPlayer()
        {
            Debug.Log("Resetting Player");
        }

        private void OnDisable()
        {
            Player.onDeath -= ResetPlayer;
        }
    }
}
