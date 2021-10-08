using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dictionaries - key-value pairs
/// - keys must be unique and must exist
/// - pairs must be unique, but values may be duplicated
/// - useful when working with large lists 
/// - direct access to elements (values), no need to iterate
/// - use int or string for key
/// </summary>
namespace DictionariesSpace
{
    public class ItemDatabase : MonoBehaviour
    {
        // List to compare
        public List<Item> itemList = new List<Item>();

        // key-value pairs, does not display in the Inspector
        public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

        private void Start()
        {
            Item sword = new Item();
            sword.name = "Sword";
            sword.id = 0;

            Item bread = new Item();
            bread.name = "Bread";
            bread.id = 1;

            Item cape = new Item();
            cape.name = "Cape";
            cape.id = 2;


            // add item to a list
            itemList.Add(sword);   // more complicated to retrieve the sword

            // add item to a dictionary
            itemDictionary.Add(0, sword);   // retrieve the sword with the key, 0
            itemDictionary.Add(1, bread);
            itemDictionary.Add(2, cape);

            // accessing the items
            var randomItem = itemDictionary[0];
            // item0.id;
            // item0.name;

            // illegal request - must check for validity
            if (itemDictionary.ContainsKey(60))
            {
                Debug.Log("Key exists!");
                var illegalItem = itemDictionary[60];
            }
            else
            {
                Debug.Log("Key does not exist!");
            }

            // accessing all the key-value pairs
            foreach (KeyValuePair<int, Item> item in itemDictionary)
            {
                Debug.Log("Key: " + item.Key + " Value: " + item.Value.name);
            }

            // accessing all the keys
            foreach (int key in itemDictionary.Keys)
            {
                Debug.Log("Key: " + key);  // returns the keys in random order
            }

            // accessing all the values
            foreach (Item value in itemDictionary.Values)
            {
                Debug.Log("Value: " + value.name);
            }
        }

    } 
}
