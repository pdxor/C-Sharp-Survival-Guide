using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    [System.Serializable]
    public class Consumable : Item
    {
        public int addHealth;
        public bool poison;
    } 
}
