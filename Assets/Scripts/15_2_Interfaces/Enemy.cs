using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceSpace
{
    public class Enemy : MonoBehaviour, IDamagable, Shoot
    {
        public int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Damage(int damageAmount)
        {
            //throw new System.NotImplementedException();
            Health -= damageAmount;
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }
    }
}
