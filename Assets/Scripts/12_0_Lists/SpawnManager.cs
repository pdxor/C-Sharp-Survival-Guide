using System.Collections;
using System.Collections.Generic;   // Lists methods
using UnityEngine;

namespace ListsIntroSpace
{
    /// <summary>
    /// Lists
    /// - Can hold different object types (heterogeneous)
    /// - Size can be updated during runtime (dynamic)
    /// - Creates Elements in the Inspector the same as Arrays
    /// - Access the elements the same way, with and index in []
    /// </summary>
    public class SpawnManager : MonoBehaviour
    {
        // Lists - heterogeneous types
        public List<GameObject> objectsToSpawn = new List<GameObject>();

        // Arrays - homogeneous type
        public GameObject[] enemiesToSpawn = new GameObject[10];


        private void Start()
        {
            // initialize Lists
            objectsToSpawn.Add(new GameObject());
            //objectsToSpawn.Remove();
            //objectsToSpawn.Clear();
            //int numObjs = objectsToSpawn.Count;
            // etc.

            // initialize Arrays
            enemiesToSpawn[0] = new GameObject();
        }
    } 

    
}
