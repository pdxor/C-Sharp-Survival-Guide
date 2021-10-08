using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericInterfacesSpace
{
    public class Player : MonoBehaviour, IDamagable<int>, Shoot
    {
        public int Health { get; set; }   // from T

        public void Damage(int damageAmount)    // from T
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
