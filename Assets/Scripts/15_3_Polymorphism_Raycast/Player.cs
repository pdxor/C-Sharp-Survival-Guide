using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PolymorphismSpace
{
    public class Player : MonoBehaviour, IDamagable, Shoot
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            Health -= damageAmount;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }
    }
}
