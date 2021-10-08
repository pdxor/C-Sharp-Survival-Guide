using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumsCustomClassesSpace
{
    public class ItemDatabase : MonoBehaviour
    {
        public List<Item> itemDB = new List<Item>();

        private void Start()
        {
            itemDB[0].Action();
            itemDB[1].Action();
        }
    } 
}
