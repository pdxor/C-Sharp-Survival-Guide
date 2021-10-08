using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityHelperSpace
{
    public class Player : MonoBehaviour
    {
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // call UtilityHelper method
                UtilityHelper.CreateObject();
            }

            // reset object position to (0, 0, 0)
            if (Input.GetKeyDown(KeyCode.Z))
            {
                UtilityHelper.SetPositionToZero(this.gameObject);
            }

            // change object to random color
            if (Input.GetKeyDown(KeyCode.X))
            {
                UtilityHelper.ChangeColor(this.gameObject, Color.white, true);
            }

            // change object color to red
            if (Input.GetKeyDown(KeyCode.R))
            {
                UtilityHelper.ChangeColor(this.gameObject, Color.red);
            }

            // change object color to green
            if (Input.GetKeyDown(KeyCode.G))
            {
                UtilityHelper.ChangeColor(this.gameObject, Color.green);
            }

            // change object color to blue
            if (Input.GetKeyDown(KeyCode.G))
            {
                UtilityHelper.ChangeColor(this.gameObject, Color.blue);
            }
        }
    } 
}
