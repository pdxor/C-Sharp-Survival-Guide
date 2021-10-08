using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemDatabase
{
    // cannot see attributes of a non-Monobehaviour class object in Inspector!
    // class declaration must include [System.Serializable]
    public class ItemDatabase : MonoBehaviour
    {
        [SerializeField] private Item _sword;
        [SerializeField] private Item _hammer;
        [SerializeField] private Item _bread;

        // Start is called before the first frame update
        void Start()
        {
            // 3 ways to create an Item object:

            _sword = new Item();
            _sword.name = "Sword";
            _sword.id = 1;
            _sword.description = "This is a sword!";

            _hammer = new Item("Hammer", 2, "This is a hammer!");

            _bread = CreateItem("Bread", 3, "I can eat this");

        }

        private Item CreateItem(string name, int id, string description)
        {
            //var item = new Item(name, id, description);
            Item item = new Item(name, id, description);

            return item;
        }
    }
}
