using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualOverride
{
    public class Duck : Pet
    {
        protected override void Speak()
        {
            Debug.Log("Quack!");
        }

        void Start()
        {
            Speak();
        }

        void Update()
        {

        }
    } 
}
