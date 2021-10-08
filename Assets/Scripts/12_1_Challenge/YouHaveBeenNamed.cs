using System.Collections;
using System.Collections.Generic;   // Lists methods
using UnityEngine;

/// <summary>
/// Challenge 12-1:
/// Create a list of names and print out each one
/// When the Space key is pressed, remove a random element and reprint the names
/// </summary>
namespace ListsChallenge1Space
{
    public class YouHaveBeenNamed : MonoBehaviour
    {
        [SerializeField] private List<string> namesList = new List<string>();

        void Start()
        {
            namesList.Add("John");
            namesList.Add("Jessica");
            namesList.Add("James");
            namesList.Add("Julia");
            namesList.Add("Jannet");

            PrintNamesList();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RemoveRandomElement();
                PrintNamesList();
            }


        }

        void PrintNamesList()
        {
            Debug.Log("=============");
            foreach (var name in namesList)
            {
                Debug.Log(name);
            }
        }

        void RemoveRandomElement()
        {
            if (namesList.Count > 0)
            {
                int randomElement = Random.Range(0, namesList.Count);
                string nameRemoved = namesList[randomElement];
                namesList.RemoveAt(randomElement);
                Debug.LogError("Removed: " + nameRemoved + " at index = " + randomElement);
            }
        }
    } 
}
