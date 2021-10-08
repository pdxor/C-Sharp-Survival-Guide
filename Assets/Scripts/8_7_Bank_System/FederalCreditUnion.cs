using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BankSystem
{
    [System.Serializable]
    public class FederalCreditUnion : Bank
    {
        protected int availableCashToLend;

        protected void ApproveLending()
        {
            Debug.Log("You are awarded a loan!");
        }
    } 
}
