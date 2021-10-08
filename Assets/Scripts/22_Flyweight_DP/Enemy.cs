using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Flyweight Design Pattern
/// Optimization for large number of the same object
/// Couple shared properties by using static or Scriptable Objects (data containers)
/// </summary>
namespace Flyweight_DP_Space
{
    public class Enemy : MonoBehaviour
    {
        // unique to each enemy
        [SerializeField] private int _currentHealth;

        // common to every enemy
        [SerializeField] private static int _maxHealth = 100;
        [SerializeField] private static float _speed = 5;

        private void Start()
        {
            _currentHealth = _maxHealth;
        }

        // common to every enemy
        public static void Damage()
        {

        }
    } 
}
