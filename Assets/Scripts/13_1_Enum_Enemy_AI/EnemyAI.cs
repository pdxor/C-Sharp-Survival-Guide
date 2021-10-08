using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumEnemyAISpace
{
    public class EnemyAI : MonoBehaviour
    {
        public enum EnemyState
        {
            Patroling,
            Attacking,
            Chasing,
            Death
        }

        public EnemyState currentState;

        void Start()
        {
            currentState = EnemyState.Patroling;
        }

        void Update()
        {
            switch (currentState)
            {
                case EnemyState.Patroling:
                    Debug.Log("Enemy State: Patroling");
                    if (Time.time > 5)
                    {
                        currentState = EnemyState.Chasing;
                    }
                    break;
                case EnemyState.Attacking:
                    Debug.Log("Enemy State: Attacking");
                    break;
                case EnemyState.Chasing:
                    Debug.Log("Enemy State: Chasing");
                    break;
                case EnemyState.Death:
                    Debug.Log("Enemy State: Dying");
                    break;
                default:
                    break;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                // switch all enemies to Attack state
                currentState = EnemyState.Attacking;
            }
        }
    } 
}
