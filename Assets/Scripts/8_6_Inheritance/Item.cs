using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    [System.Serializable]
    public class Item
    {
        // attributes
        public string name;
        public int id;
        public string description;
        public Sprite icon;

        // default constructor
        public Item()
        {

        }

        // custom constructor
        public Item(string name, int id, string description)
        {
            this.name = name;
            this.id = id;
            this.description = description;
        }
    }
}