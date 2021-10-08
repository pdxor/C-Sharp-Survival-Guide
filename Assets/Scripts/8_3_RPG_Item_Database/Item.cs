using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemDatabase
{
    // cannot see attributes of a non-Monobehaviour class object in Inspector!
    // class declaration must include [System.Serializable]
    [System.Serializable]
    public class Item
    {
        public string name;
        public int id;
        public string description;
        public Sprite icon;

        public Item()
        {

        }
        public Item(string name, int id, string description)
        {
            this.name = name;
            this.id = id;
            this.description = description;
        }
    }
}
