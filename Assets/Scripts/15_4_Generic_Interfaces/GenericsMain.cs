using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericInterfacesSpace
{
    public class GenericsMain : MonoBehaviour
    {
        void Update()
        {
            // check for left mouse clock
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(rayOrigin, out hitInfo))
                {
                    // interface advantage is supposed to be polymorphism
                    // however, not able to use with generics
                    //IDamagable<T> obj = hitInfo.collider.GetComponent<IDamagable<T>>();
                    IDamagable<int> obj = hitInfo.collider.GetComponent<IDamagable<int>>();
                    if (obj != null)
                    {
                        obj.Damage(100);
                    }
                }
            }
        }
    } 
}
