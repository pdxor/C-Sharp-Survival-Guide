using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
    public class IterateObjects : MonoBehaviour
    {
        public GameObject[] cubes;

        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //foreach (var cube in cubes)
                //{
                //    cube.GetComponent<MeshRenderer>().material.color = Color.red;
                //}

                for (int i = 0; i < cubes.Length; i++)
                {
                    cubes[i].GetComponent<MeshRenderer>().material.color = Color.green;
                }
            }
        }
    }
}
