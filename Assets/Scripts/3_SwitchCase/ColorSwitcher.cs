using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Challenge P02:
/// Use a switch statement to change the color of a cube
/// - 1 key -> blue 
/// - 2 key -> red
/// - 3 key -> green
/// - 4 key-> black
/// </summary>

namespace SwitchCase
{
    public class ColorSwitcher : MonoBehaviour
    {
        public GameObject _object;

        [SerializeField]
        private int _blue;
        [SerializeField]
        private int _red;
        [SerializeField]
        private int _green;
        [SerializeField]
        private int _black;
        [SerializeField]
        private int _chosen;

        // Start is called before the first frame update
        void Start()
        {
            _blue = 1;
            _red = 2;
            _green = 3;
            _black = 4;
            _chosen = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _chosen = _blue;
            } 
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _chosen = _red;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _chosen = _green;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                _chosen = _black;
            }
            else
            {
                Debug.Log("Select: 1=Blue, 2=Red, 3=Green, or 4=Black");
            }

            switch (_chosen)
            {
                case 1:
                    _object.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case 2:
                    _object.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 3:
                    _object.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 4:
                    _object.GetComponent<Renderer>().material.color = Color.black;
                    break;
                default:
                    Debug.Log("Must select a color code: 1, 3, 3, or 4");
                    break;
            }
        }
    }
}