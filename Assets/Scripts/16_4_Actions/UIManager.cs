using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionsSpace
{
    public class UIManager : MonoBehaviour
    {
        public void OnEnable()
        {
            Player.OnDamageReceived += UpdateHealth;  
        }
        public void UpdateHealth(int health)
        {
            // display updated health in UI
            Debug.Log("Current Health = " + health);
        }
    } 
}
