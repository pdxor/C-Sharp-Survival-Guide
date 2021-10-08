using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Static Class accessible by all other classes in the namespace
// Cannot inherit from MonoBehaviour
// All attributes and methods must also be static
// Held in memory indefinitely for the life of the program
namespace UtilityHelperSpace
{
    public static class UtilityHelper
    { 
        public static void CreateObject()
        {
            // create a new primitive cube
            GameObject.CreatePrimitive(PrimitiveType.Cube);
        }

        public static void SetPositionToZero(GameObject obj)
        {
            obj.transform.position = Vector3.zero;
        }

        // randomize the color of the game object
        public static void ChangeColor(GameObject obj, Color color, bool randomColorDesired = false)
        {
            if(randomColorDesired == true)
            {
                color = new Color(Random.value, Random.value, Random.value);
            }

            obj.GetComponent<MeshRenderer>().material.color = color;
        }
    }

}