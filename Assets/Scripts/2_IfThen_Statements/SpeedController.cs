using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Increment the speed when the '+' key is pressed
/// Decrement the speed when the '-' key is pressed
/// When the speed is greater than 20, print "Slow Down!"
/// When the speed reaches 0, print "Speed Up!"
/// Speed cannot go below 0.
/// </summary>

 namespace Conditionals
{
    public class SpeedController : MonoBehaviour
    {
        [SerializeField]
        private int _speed;
        [SerializeField]
        private int _min;
        [SerializeField]
        private int _limit;
        [SerializeField]
        private int _interval;

        // Start is called before the first frame update
        void Start()
        {
            _speed = 0;
            _min = 0;
            _limit = 20;
            _interval = 5;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _speed += _interval;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                _speed -= _interval;
                if (_speed < _min)
                {
                    _speed = _min;
                }
            }

            if (_speed >= _limit)
            {
                Debug.Log("Slow Down!!");
            }
            else if (_speed == _min)
            {
                Debug.Log("Speed Up!");
            }
            else
            {
                Debug.Log("Good Speed :o)");
            }
        }
    }
}