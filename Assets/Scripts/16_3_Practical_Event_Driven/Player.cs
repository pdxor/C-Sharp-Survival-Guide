using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticalEventDrivenSpace
{
    public class Player : MonoBehaviour
    {
        public delegate void OnDeath();
        public static event OnDeath onDeath;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Death();
            }
        }

        void Death()
        {
            // no longer required with event driven system!
            //GameObject.FindObjectOfType<GameManager>().ResetPlayer();
            //GameObject.FindObjectOfType<UIManager>().UpdateDeathCount();

            onDeath();
        }
    } 
}
