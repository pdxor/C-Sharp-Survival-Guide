using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChallengeEmployeeProfileSpace
{
    public class Main : MonoBehaviour
    {
        public PartTimeEmployee ptEmployee;
        public FullTimeEmployee ftEmployee;
        private float _monthlyPay = 0.00f;

        void Start()
        {
            _monthlyPay = ptEmployee.CalculateMonthlySalary();
            Debug.LogError(ptEmployee.name + " has a monthly salary of $" + _monthlyPay);

            _monthlyPay = ftEmployee.CalculateMonthlySalary();
            Debug.LogError(ftEmployee.name + " has a monthly salary of $" + _monthlyPay);
        }
    }
}
