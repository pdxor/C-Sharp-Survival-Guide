using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeleportEventsSpace
{
    public class Puck : MonoBehaviour
    {
        void Start()
        {
            TeleportMain.onTeleport += Spawn;
        }

        void Update()
        {

        }

        public void Spawn(Vector3 pos)
        {
            transform.position = pos;
        }

        private void OnDisable()
        {
            TeleportMain.onTeleport -= Spawn;
        }
    } 
}
