using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunctionMethods {
    public class ChangePosition : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ResetPosition();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position = GetPosition(1f, 1f, 1f);
            }
        }

        void ResetPosition()
        {
            transform.position = new Vector3(0, 0, 0);
        }

        Vector3 GetPosition(float x, float y, float z)
        {
            Vector3 pos = new Vector3(x, y, z);
            return pos;
        }


    }
}
