using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListInventoryDBSpace
{
    // ideally, this class should be a singleton
    public class ItemListDB : MonoBehaviour
    {
        public List<Item> _itemDatabase = new List<Item>();

        public void AddItem(int itemID, Player player)
        {
            foreach (var item in _itemDatabase)
            {
                if (itemID == item.id)
                {
                    Debug.Log("We have a match! ID = " + itemID);
                    // check for available inventory slots
                    player.inventory[0] = item;
                    return;
                }
            }

            Debug.Log("This item does not exist! ID = " + itemID);
        }

        public void RemoveItem(int itemID, Player player)
        {
            foreach (var item in _itemDatabase)
            {
                if (itemID == item.id)
                {
                    Debug.Log("We have a match! ID = " + itemID);
                    //
                    player.inventory[0] = null;
                    return;
                }
            }
        }
    } 
}
