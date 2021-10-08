using System;   // Actions
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionsSpace
{
    public class Player : MonoBehaviour
    {
        // long way...
        //public delegate void OnDamageReceived(int currentHealth);
        //public static event OnDamageReceived onDamage;

        // shortcut Action
        public static Action<int> OnDamageReceived;

        public int Health { get; set; }
        void Start()
        {
            Health = 10;
        }

        void Damage()
        {
            Health--;
            //UIManager.UpdateHealth(Health);
            //if (onDamage != null)
            //{
            //    onDamage(Health);
            //}

            if (OnDamageReceived != null)
            {
                OnDamageReceived(Health);
            }
        }
    }
}