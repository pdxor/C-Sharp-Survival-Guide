using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Initialize Static Members with a Static Constructor
namespace StaticConstructorSpace
{
    public class Employee
    {
        public int employeeID;
        public string first, last;
        public int salary;

        public static string company;

        // Static Constructor - will be called first, once
        // regardless of what order this constructor is declared
        static Employee()
        {
            company = "GameDev HQ";
            Debug.Log("Static member initialized");
        }

        // instance constructor will be called for each object created
        public Employee()
        {
            Debug.Log("Instance members initialized");
        }

    }

    public class StaticConstructorTest : MonoBehaviour
    {
        private void Start()
        {
            Employee emp1 = new Employee();
            var emp2 = new Employee();
            var emp3 = new Employee();
            var emp4 = new Employee();
            Employee emp5 = new Employee();

        }
    }

}
