using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Access all array items with for and foreach loops
/// </summary>
namespace Arrays
{
    public class AccessLoops : MonoBehaviour
    {
        public int[] itemId;
        public string[] itemName;

        void Start()
        {

        }

        void Update()
        {
            // implemented with a for loop
            // find the itemId for a requested itemName
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    for (int i = 0; i < itemName.Length; i++)
            //    {
            //        if (itemName[i] == "sword")
            //        {
            //            Debug.Log(itemName[i] + " Exists!");
            //            Debug.Log("Item ID: " + itemId[i]);
            //        }
            //    }
            //}

            // implemented with a foreach loop
            // note: no index available?
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var item in itemName)
                {
                    if (item == "sword")
                    {
                        Debug.Log(item + " Exists!");
                        //Debug.Log("Item Id: " + itemId[item.IndexOf(item)]);
                    }
                }
            }
        }
    }
}
