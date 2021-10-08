using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Begin with a red game object
/// Increment the score by 10 when the space key is pressed
/// Turn the object to green when the score reaches a multiple of  50
/// </summary>

namespace Conditionals
{
    public class ColorChanger : MonoBehaviour
    {
        public GameObject _object;
        [SerializeField]
        private int _score;

        // Start is called before the first frame update
        void Start()
        {
            _score = 0;
            _object.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _score += 10;
                if(_score % 50 == 0)
                {
                //_object.GetComponent<MeshRenderer>().material.color = Color.green;
                _object.GetComponent<Renderer>().material.color = Color.green;
                }
                else
                {
                    _object.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }
}
