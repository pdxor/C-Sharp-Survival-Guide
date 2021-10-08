using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Objective:
/// Increment the value of speed every 5 seconds
/// Set max speed to a random value between 60 and 120
/// When speed is greater than max speed, stop incrementing
/// 
/// Hint: Use a coroutine
/// </summary>

namespace Loops
{
    public class IncrementSpeed : MonoBehaviour
    {
        [SerializeField]
        private int _speed;
        [SerializeField]
        private int _interval;
        [SerializeField]
        private int _limit;
        [SerializeField]
        private float _waitTime;

        void Start()
        {
            _speed = 0;
            _interval = 10;
            _limit = Random.Range(60, 121);
            _waitTime = 1.0f;

            StartCoroutine(IncrementSpeedRoutine());
        }

        void Update()
        {

        }

        private IEnumerator IncrementSpeedRoutine()
        {
            // while loop implementation
            while (_speed < _limit)
            {
                _speed += _interval;
                yield return new WaitForSeconds(_waitTime);
            }

            // --- or ---

            // infinite loop implementation
            //while (true)
            //{
            //    _speed += _interval;
            //    yield return new WaitForSeconds(_waitTime);

            //    if (_speed > _limit)
            //    {
            //        break;
            //    }
            //}

            // --- or ---

            // do..while loop implementation
            //do
            //{
            //    _speed += _interval;
            //    yield return new WaitForSeconds(_waitTime);

            //} while (_speed < _limit);
        }
    }
}
