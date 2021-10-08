using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChallengeEmployeeProfileSpace
{
    public class FullTimeEmployee : Employee
    {
        public float salary;

        public override float CalculateMonthlySalary()
        {
            //throw new System.NotImplementedException();
            return salary;
        }
    } 
}
