using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Challenge P01: Print message when points are 50 or 100.
/// </summary>
namespace SwitchCase
{
    public class SwitchPoints : MonoBehaviour
    {
        [SerializeField]
        private int _points;

        // Start is called before the first frame update
        void Start()
        {
            _points = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _points = 50;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                _points = 100;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                _points = 0;
            }

            switch (_points)
            {
                case 50:
                    Debug.Log("50 Points!");
                    break;
                case 100:
                    Debug.Log("100 Points!");
                    break;
                default:
                    Debug.Log("Need 50 or 100 points to receive a message");
                    break;
            }
        }
    }
}
