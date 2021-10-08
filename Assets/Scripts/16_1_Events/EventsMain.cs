using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Event Broadcast/Notification System
/// - Observer Pattern - Subscribers and Listeners
/// - Listeners here
/// - Change color of cube (listeners) objects
/// - Attach to Main Camera
/// - Main Camera does not know about the Cubes
/// - Specialized Event - Events have inherent security, and Delegates do not
/// </summary>
namespace BroadcastSystemSpace
{
    public class EventsMain : MonoBehaviour
    {
        public delegate void ActionClick();
        public static event ActionClick onClick;

        public void ButtonClick()
        {
            // turn all cubes red
            if (onClick != null)
            {
                onClick();
            }
        }
    } 
}
