using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variables
{
    public class Item : MonoBehaviour
    {
        public string itemName;
        public string itemDescription;
        public int itemAttackStrength;
        public Sprite itemIcon;   // sprite image

        void Start()
        {
            itemName = "Sword";
            itemDescription = "This is a power sword.";
            itemAttackStrength = 15;

            Debug.Log("Item Name: " + itemName);
            Debug.Log("Item Description: " + itemDescription);
            Debug.Log("Item Attack Strength: " + itemAttackStrength);
        }
    }
}
