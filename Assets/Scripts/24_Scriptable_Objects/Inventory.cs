using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// All in one inventory system using Scriptable Objects
/// </summary>
public class Inventory : MonoBehaviour
{
    // drag bread, scroll, and dagger objects into this list in the Inspector
    public List<Item> itemDatabase;

    private void Start()
    {
        // can also use LINQ
        itemDatabase.ForEach(i => i.PrintName());
    }
}
