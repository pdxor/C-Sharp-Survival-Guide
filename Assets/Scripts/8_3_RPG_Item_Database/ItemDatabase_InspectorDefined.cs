using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemDatabase
{
    // cannot see attributes of a non-Monobehaviour class object in Inspector!
    // class declaration must include [System.Serializable]
    public class ItemDatabase_InspectorDefined : MonoBehaviour
    {
        // Fill in the details in the Inspector
        // Notice that whatever is entered in the name fields also appears as the name header for that Item
        [SerializeField] private Item[] _items;

        // accessing the items
        private void Start()
        {
            Debug.Log("First Item is: " + _items[0].name);
        }
    }
}
