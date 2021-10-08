using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PolymorphismSpace
{
    public class Main : MonoBehaviour
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
                    // non-interface needs to check for Player and Enemy:
                    //if (hitInfo.collider.name == "Player")
                    //{
                    //    hitInfo.collider.GetComponent<Player>().Damage(100);
                    //}

                    //else if (hitInfo.collider.name == "Enemy")
                    //{
                    //    hitInfo.collider.GetComponent<Enemy>().Damage(100);
                    //}

                    // interface, just check for the interface
                    IDamagable obj = hitInfo.collider.GetComponent<IDamagable>();
                    if (obj != null)
                    {
                        obj.Damage(100);
                    }
                }
            }
        }
    } 
}
