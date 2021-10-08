using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// For Loops: When you know how many iterations are required ahead of time 
/// 
/// Use cases:
/// - Iterate through all monsters in a "blast" zone and deal appropriate damage
/// - Shatter an object (requires looping through each individual piece and adding physics)
/// - When you add an item to a player inventory, you need to loop through the database to see if that item exists before adding it
/// - You want to turn all game objects in view RED (You need to iterate through each object using a loop and affect each one)
/// </summary>

namespace Loops
{
    public class ForLoops : MonoBehaviour
    {
        [SerializeField]
        private string _name = "jmacnut";

        // Start is called before the first frame update
        void Start()
        {
            for  (int i = 0; i < 10; i++)
            {
                Debug.Log(_name);
            }

            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Debug.Log("Even Number: " + i);

                    if(i == 42)
                    {
                        break;
                    }
                }
                if (i % 2 == 1)
                {
                    Debug.Log("Odd Number: " + i);
                }
            }

            Debug.Log("Loop Ended");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
