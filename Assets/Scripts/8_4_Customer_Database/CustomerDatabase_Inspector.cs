using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomerDatabase
{
    public class CustomerDatabase_Inspector : MonoBehaviour
    {
        [SerializeField] private Customer[] customerDatabase;

        private void Awake()
        {
            foreach (var customer in customerDatabase)
            {
                customer.PrintCustomer();
            }
        }
        private void Start()
        {
            //foreach (var customer in customerDatabase)
            //{
            //    customer.PrintCustomer();
            //}
        }

    }
}
