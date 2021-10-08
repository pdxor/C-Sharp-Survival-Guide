using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomClasses
{
    public class Powerup : MonoBehaviour
    {
        private WeaponStats _blasters;

        void Start()
        {
            // assign a weapon to give to player upon collecting
            _blasters = new WeaponStats("Blaster", 0.25f, 50);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                UIManager.Instance.UpdateWeaponStats(_blasters);
                Destroy(this.gameObject);
            }
        }
    }
}
