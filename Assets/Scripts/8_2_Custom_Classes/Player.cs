using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Custom Classes and Constructors
/// </summary>
namespace CustomClasses
{
    //// class declaration can be within same script or on its own separate script (preferred)
    //public class WeaponStats
    //{
    //    public string name;
    //    public float fireRate;
    //    public int ammoCount;

    //    // constructor
    //    public WeaponStats(string name, float fireRate, int ammoCount)
    //    {
    //        this.name = name;
    //        this.fireRate = fireRate;
    //        this.ammoCount = ammoCount;
    //    }
    //}

    public class Player : MonoBehaviour
    {
        // create the references
        private WeaponStats _blasters;
        private WeaponStats _rockets;

        void Start()
        {
            _blasters = new WeaponStats("Blasters", 0.25f, 50);
            _rockets = new WeaponStats("Rockets", 5f, 1);

            Debug.Log("Current Weapon Name: " + _blasters.name);
        }

        void Update()
        {
            
        }
    }

}
