using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpellSystem
{
    [System.Serializable]
    public class Spell
    {
        public string name;
        public int itemIdRequired;
        public int levelRequired;
        public int experienceRequired;

        public Spell(string name, int itemIdRequired, int levelRequired, int experienceRequired)
        {
            this.name = name;
            this.itemIdRequired = itemIdRequired;
            this.levelRequired = levelRequired;
            this.experienceRequired = experienceRequired;
        }

        public void CastSpell()
        {
            Debug.Log("Casting Spell: " + this.name);

        }
    } 
}
