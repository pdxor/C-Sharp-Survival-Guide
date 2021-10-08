using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PolymorphismSpace
{
    public class Enemy : MonoBehaviour, IDamagable, Shoot
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            //throw new System.NotImplementedException();
            Health -= damageAmount;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }
    }
}
