using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Note: Scriptable Objects cannot be attached to game objects
/// </summary>

[CreateAssetMenu(fileName = "item.asset", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public int itemID;
    public Sprite icon;
    public int gold;
    public GameObject mesh;

    public void PrintName()
    {
        Debug.Log("Item Name: " + itemName);
    }
}
