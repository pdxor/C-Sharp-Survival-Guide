using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChallengeEmployeeProfileSpace
{
    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
        public float hoursWorked;

        private void Start()
        {
            hourlyRate = 20.00f;
            hoursWorked = 168.00f;
        }
        public override float CalculateMonthlySalary()
        {
            //throw new System.NotImplementedException();
            float monthlySalary = hourlyRate * hoursWorked;
            return monthlySalary;
        }

    } 
}
