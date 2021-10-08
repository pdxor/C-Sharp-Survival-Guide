using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    public class ItemDatabase : MonoBehaviour
    {
        [SerializeField] private Item _goldCoin = new Item();
        [SerializeField] private Weapon _sword = new Weapon();
        [SerializeField] private Consumable _bread = new Consumable();

        void Start()
        {

        }

        void Update()
        {

        }
    } 
}
