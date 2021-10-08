using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Calculate the total bill including tip
/// </summary>
namespace Variables
{
    public class TipCalculator : MonoBehaviour
    {
        public int bill = 40;
        public float tip = 20.0f;
        public float totalAmount = 0.0f;

        // Start is called before the first frame update
        void Start()
        {
            float tipAmount = bill * (tip/100);
            totalAmount = bill + tipAmount;

            Debug.Log("Your bill is: $" + bill + " and your tip amount is: $" + tipAmount + ", so you owe: $" + totalAmount);
        }
    }
}
