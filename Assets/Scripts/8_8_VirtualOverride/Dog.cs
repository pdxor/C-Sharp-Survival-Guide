using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualOverride
{
    public class Dog : Pet
    {
        protected override void Speak()
        {
            Debug.Log("Woof!");
        }

        private void Start()
        {
            Speak();
        }
    } 
}
