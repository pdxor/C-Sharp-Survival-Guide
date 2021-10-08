using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomerDatabase
{
    public class CustomerDatabase_HardCode : MonoBehaviour
    {
        [SerializeField] private Customer _jonathan;
        [SerializeField] private Customer _jannet;
        [SerializeField] private Customer _jessica;

        private void Start()
        {
            _jonathan = new Customer("Jonathan", "Weinberger", 26, "M", "Software Engineer");
            _jannet = new Customer("Jannet", "", 55, "F", "Instructor");
            _jessica = new Customer("Jessica", "Lang", 37, "F", "Scientist");

            _jonathan.PrintCustomer();
            _jannet.PrintCustomer();
            _jessica.PrintCustomer();
        }

    }
}
