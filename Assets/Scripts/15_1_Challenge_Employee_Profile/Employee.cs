using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChallengeEmployeeProfileSpace
{
    public abstract class Employee : MonoBehaviour
    {
        public static string companyName = "GameDev HQ";
        public string employeeName;

        public abstract float CalculateMonthlySalary();
    } 
}
