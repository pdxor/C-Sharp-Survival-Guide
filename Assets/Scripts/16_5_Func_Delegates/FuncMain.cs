using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FUNC Delegates are Return Type Delegates (non void type return value)
/// Create a program that takes in a string and returns the length of it (number of characters)
/// </summary>
namespace FuncDelegatesSpace
{
    public class FuncMain : MonoBehaviour
    {
        // traditional way to call a method
        //void Start()
        //{
        //    int characterCount = GetCharacters("Yoda");
        //    Debug.Log("Character Count: " + characterCount);
        //}

        //int GetCharacters(string name)
        //{
        //    return name.Length;
        //}

        // event and delegate
        public delegate int CharacterLength(string name);
        public static event CharacterLength character_length;


    } 
}
