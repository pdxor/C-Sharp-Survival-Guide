using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StructsSpace
{
    // A struct is a VALUE Type (holds the actual data in memory)
    // int, float, bool, long, char
    // when passing into a function, makes a copy so routine cannot modify the original value
    // Stored on the STACK
    // struct does not support inheritance
    // same declaration as class
    // does not require the 'new' keyword
    public struct Item2
    {
        public string name;
        public int itemID;

        public Item2(string name, int itemID)
        {
            this.name = name;
            this.itemID = itemID;
        }
    } 

    // A class is a REFERENCE Type (holds the address pointer to the value in memory)
    // strings, arrays, classes, delegates
    // can modify the by reference when passed to a function
    // Stored on the HEAP
    // class supports inheritance
    public class Item
    {
        public string name;
        public int itemID;

        public Item(string name, int itemID)
        {
            this.name = name;
            this.itemID = itemID;
        }
    }

    //public class Structs : MonoBehaviour
    //{
    //    Item sword;

    //    private void Start()
    //    {
    //        sword = new Item("Sword", 1);
    //    }
    //}


    public class Structs : MonoBehaviour
    {
        Item sword = new Item("Sword", 1);
        Item2 bread;   // does not require the 'new' keyword

        private void Start()
        {
            // by value
            bread.name = "Bread";
            bread.itemID = 2;

            // by reference - changes
            Debug.Log("Sword's Current Name (before method call): " + sword.name);
            ChangeValue(sword);
            Debug.Log("Sword's Current Name (after method call): " + sword.name);
            
            // by value - does not change
            Debug.Log("Sword's Current Name (before method call): " + bread.name);
            ChangeValue(bread);
            Debug.Log("Sword's Current Name (after method call): " + bread.name);
        }

        // pass by value
        void ChangeValue(Item2 structItem)
        {
            structItem.name = "Dirty Bread";

            Debug.Log("Bread's Original Name: " + structItem.name);   // the original value, unchanged
        }

        // pass by reference
        void ChangeValue(Item classItem)
        {
            classItem.name = "Master Sword";   // change the name from Sword 
        }
    }
}
