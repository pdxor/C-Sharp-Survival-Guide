using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceSpace
{
    public class Player : MonoBehaviour, IDamagable, Shoot
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            Health -= damageAmount;
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }
    }
}
