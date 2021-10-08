using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Weapons Selector
/// ID 1 = Gun
/// ID 2 = Knife
/// ID 3 = Machine Gun
/// </summary>

namespace SwitchCase
{
    public class WeaponSelect : MonoBehaviour
    {
        [SerializeField]
        private int weaponId = 0;

        void Start()
        {

        }

        void Update()
        {
            switch(weaponId)
            {
                case 1:
                    Debug.Log("GUN");
                    break;
                case 2:
                    Debug.Log("KNIFE");
                    break;
                case 3:
                    Debug.Log("MACHINE GUN");
                    break;
                default:
                    Debug.Log("Invalid Weapon ID: 1=Gun, 2=Knife, 3=Machine Gun");
                    break;
            }
        }
    }
}
