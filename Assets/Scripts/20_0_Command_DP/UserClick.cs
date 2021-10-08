using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UserClick
/// - Allow user to move around?
/// - Attach to main camera
/// </summary>
namespace Command_DP_Space
{
    public class UserClick : MonoBehaviour
    {
        void Update()
        {
            // 0 = left mouse click
            if (Input.GetMouseButtonDown(0))
            {
                // cast a ray to mouse position
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;   // stores info for object that was hit with the ray

                if (Physics.Raycast(rayOrigin, out hitInfo))   // store in collider
                {
                    // detect a cube
                    if (hitInfo.collider.tag == "Cube")
                    {
                        // assign a random color to the cube
                        //hitInfo.collider.GetComponent<MeshRenderer>().material.color = new Color(
                        //Random.value, Random.value, Random.value);

                        // Command DP
                        ICommand click = new ClickCommand(hitInfo.collider.gameObject, new Color(Random.value, Random.value, Random.value));
                        click.Execute();
                        CommandManager.Instance.AddCommand(click);
                    }
                }

            }
        }
    } 
}
