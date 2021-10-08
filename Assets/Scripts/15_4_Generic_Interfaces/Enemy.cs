using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericInterfacesSpace
{
    public class Enemy : MonoBehaviour, IDamagable<float>, Shoot
    {
        public float Health { get; set; }   // from T

        public void Damage(float damageAmount)   // from T
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
