using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListInventoryDBSpace
{
    public class Player : MonoBehaviour
    {
        public Item[] inventory = new Item[10];

        private ItemListDB _itemDatabase;

        private void Start()
        {
            _itemDatabase = GameObject.Find("Item_List_DB").GetComponent<ItemListDB>();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // request item by ID, pass by reference
                _itemDatabase.AddItem(0, this);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                // remove item by ID, pass by reference
                _itemDatabase.RemoveItem(0, this);
            }
        }
    } 
}
