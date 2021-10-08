using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunctionsMethods
{
    public class CubeColor : MonoBehaviour
    {
        [SerializeField]
        private GameObject _cube;

        // Start is called before the first frame update
        void Start()
        {
            _cube = GameObject.FindGameObjectWithTag("Cube");

        }

        // Update is called once per frame
        void Update()
        {
            ChangeColor(_cube, Color.red);
        }

        private void ChangeColor(GameObject obj, Color nextColor)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                obj.GetComponent<MeshRenderer>().material.color = nextColor;
            }
        }
    }
}
