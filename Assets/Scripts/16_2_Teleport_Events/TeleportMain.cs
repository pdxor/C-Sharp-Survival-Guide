using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Challege:
/// Create a program using delegates and events where you hit the space key 
/// and assigna cube a position of (5, 2, 0).
/// The sphere script should subscribe to the event and be invoked when you hit the space key.
/// </summary>
namespace TeleportEventsSpace
{
    public class TeleportMain : MonoBehaviour
    {
        public delegate void Teleport(Vector3 position);
        public static event Teleport onTeleport;

        void Start()
        {

        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (onTeleport != null)
                {
                    Vector3 pos = new Vector3(5f, 2f, 0f);
                    onTeleport(pos);
                }
            }
        }
    } 
}
