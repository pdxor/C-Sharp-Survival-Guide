using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// static members are shared between all instance
// instances members are created as copies
namespace StaticVsInstance
{
    public class Item
    {
        // instance variables, copy made for each object
        public string name;
        public int itemId;

        // static member, shared between all objects
        public static int itemCount;

        public Item()
        {
            // everytime an object is instantiated, increment the static count
            itemCount++;
        }
    }


    public class Test : MonoBehaviour
    {
        void Start()
        {
            // instances of the Item class
            Item sword = new Item();
            Item bread = new Item();
            Item cape = new Item();
            Item fish = new Item();

            Debug.Log("Item Count = " + Item.itemCount);
        }
    } 
}
