using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpellSystem
{
    public class Wizard : MonoBehaviour
    {
        //[SerializeField] private Spell _fireBlast;
        [SerializeField] private Spell[] _spells;

        [SerializeField] private int _level = 1;
        [SerializeField] private int _experienceGained;

        void Start()
        {
            //_fireBlast = new Spell("Fire blast", 1, 27, 35);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //_fireBlast.CastSpell();
                //_experience += _fireBlast.experienceRequired;

                // iterate through the spell list and compare to my current level
                // cast spell
                foreach (var spell in _spells)
                {
                    if (spell.levelRequired == _level)
                    {
                        spell.CastSpell();
                        _experienceGained += spell.experienceRequired;
                    }

                }
            }
        }
    } 
}
