using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomerDatabase
{
    [System.Serializable]
    public class Customer
    {
        public string firstName;
        public string lastName;
        public int age;
        public string gender;
        public string occupation;

        // default constructor
        public Customer()
        {

        }

        public Customer(string firstName, string lastName, int age, string gender, string occupation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.occupation = occupation;
        }

        public void PrintCustomer()
        {
            Debug.Log("Name: " + this.firstName + " " + this.lastName);
            Debug.Log("Age: " + this.age);
            Debug.Log("Gender " + this.gender);
            Debug.Log("Occupation: " + this.occupation);
            Debug.Log("=================================================");
        }

    }
}
