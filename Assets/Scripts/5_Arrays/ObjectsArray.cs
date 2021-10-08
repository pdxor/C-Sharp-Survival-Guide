using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{
    [System.Serializable]
    public class Item
    {
        public int itemId;
        public string itemName;
        public string itemDescription;
    }

    public class ObjectsArray : MonoBehaviour
    {
        public Item[] itemsArray;

        void Start()
        {
            // iterate through the array
            //foreach (var item in itemsArray)
            //{
            //    Debug.Log(item.itemId + ": " + item.itemName);
            //}

            // find an index
            //foreach (var item in itemsArray)
            //{
            //    if (item.itemId == 7)
            //    {
            //        Debug.Log("Found Index: " + item.itemId);
            //    }
            //    else
            //    {
            //        Debug.Log("Item ID " + item.itemId + " does not exist");
            //    }
            //}

            //for (int i = 0; i < itemsArray.Length; i++)
            //{
            //    if (itemsArray[i].itemId == 7)
            //    {
            //        Debug.Log("Item ID: " + itemsArray[i].itemId + " is in inventory");
            //    }
            //    else
            //    {
            //        Debug.Log("Item ID: " + itemsArray[i].itemId + " does not exist");
            //    }
            //}

        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int randomIndex = UnityEngine.Random.Range(0, itemsArray.Length);

                Debug.Log(itemsArray[randomIndex].itemId + ": " + itemsArray[randomIndex].itemName + " - " + itemsArray[randomIndex].itemDescription);
            }
        }
    }
}
