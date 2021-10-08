using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    [System.Serializable]
    public class Weapon : Item
    {
        public int attackBonus;
        public int prayerBonus;
        public int strengthBonus;
        public int mageBonus;
    } 
}
