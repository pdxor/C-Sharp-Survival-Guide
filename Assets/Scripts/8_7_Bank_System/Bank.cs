using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BankSystem
{
    [System.Serializable]
    public class Bank
    {
        protected string branchName;
        protected string location;
        protected int cashInVault;

        protected void CheckBalance()
        {
            Debug.Log("Checking Balance at: " + branchName);
        }

        protected void Deposit()
        {
            Debug.Log("Depositing Funds To: " + branchName);
        }

        protected void Withdraw()
        {
            Debug.Log("Withdrawing Funds From: " + branchName);
        }

    } 
}
