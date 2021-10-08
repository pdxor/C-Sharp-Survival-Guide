using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Event Broadcast/Notification System
/// - Observer Pattern - Subscribers and Listeners
/// - Subscribe and Unsubscribe here
/// - Change color of cube (listeners) objects
/// - Attach to Cubes (GameObjects)
/// - Cubes do not know about Main Camera
/// - Do not need to iterate through each object
/// - Specialized Event - Events have inherent security, and Delegates do not
/// </summary>
namespace BroadcastSystemSpace
{
    public class Cube : MonoBehaviour
    {
        void Start()
        {
            // object subscribes to event
            EventsMain.onClick += ChangeColor;
        }

        public void ChangeColor()
        {
            // turn object red
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        private void OnDisable()
        {
            // object unsubscribes from event
            EventsMain.onClick -= ChangeColor;
        }
    } 
}
