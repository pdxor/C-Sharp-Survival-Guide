using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// LINQ Challenge 2:
/// - Objective 1: Check if itemID 3 exists and print out true or false
/// - Objective 2: Grab all items with buff greater than 20 and print them out
/// - Objective 3: Calculate the average of all the buff stats
/// </summary>
namespace LINQ_FilterItems_Space
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public int itemID;
        public int buff;
    }

    public class FilterItems : MonoBehaviour
    {
        public List<Item> items;

        void Start()
        {
            // Objective 1:
            var itemId3Found = items.Any(item => item.itemID == 3);
            Debug.Log("Item ID = 3: " + itemId3Found);

            // Objective 2:
            var itemsGT20 = items.Where(item => item.buff > 20);
            foreach (var item in itemsGT20)
            {
                Debug.Log("Item Buff: " + item.name + " = " + item.buff);
            }

            // Objective 3:
            //var buffAverage = items.Select(item => item.buff).Average();
            var buffAverage = items.Average(item => item.buff);   
            Debug.Log("Buff Average = " + buffAverage);

        }
    } 
}
