using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomClasses
{
    // class declaration can be within same script or on its own separate script (preferred)
    public class WeaponStats
    {
        public string name;
        public float fireRate;
        public int ammoCount;

        // constructor
        public WeaponStats(string name, float fireRate, int ammoCount)
        {
            this.name = name;
            this.fireRate = fireRate;
            this.ammoCount = ammoCount;
        }
    }
}