using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunctionMethods
{
    public class DeadOrAlive : MonoBehaviour
    {
        [SerializeField] private int _damageAmount;
        [SerializeField] private int _health;

        void Start()
        {
            _health = 100;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isAlive())
            {
                _damageAmount = Random.Range(5, 26);   // 5 to 25
                Damage(_damageAmount);
            }
        }
        
        public void Damage(int damageAmount)
        {
            _health -= damageAmount;
            Debug.Log("Health: " + _health);
            if (!isAlive())
            {
                _health = 0;
                Debug.Log("*** Player is Dead! ***");
            }
        }

       bool isAlive()
        {
            return _health > 0;
        }
    }
}
