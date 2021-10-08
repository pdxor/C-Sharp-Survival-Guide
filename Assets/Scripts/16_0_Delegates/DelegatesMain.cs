using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegatesSpace
{
    public class DelegatesMain : MonoBehaviour
    {
        // delegate type declaration
        public delegate void ChangeColor(Color newColor);
        // reference to delegate
        public ChangeColor onColorChange;

        // delegate type declaration
        public delegate void OnComplete();
        // reference to delegate
        public OnComplete onComplete;

        private void Start()
        {
            // delegate reference to delagate method reference signatures match
            onColorChange = UpdateColor;   // assign the delegate
            onColorChange(Color.green);    // invoke the delegate

            // register: stacking multiple methods onto a single delegate
            onComplete += Task1;           // assign the delegates
            onComplete += Task2;
            onComplete += Task3;

            // deregister
            onComplete -= Task1;
            onComplete -= Task2;

            // invoke the delegate
            if (onComplete != null) { 
                onComplete();
            }
        }

        // signature must match delegate's declared signature
        public void UpdateColor(Color newColor)
        {
            Debug.Log("UpdateColor(): Changing color to " + newColor.ToString());
        }

        // signature must match delegate's declared signature
        public void Task1()
        {
            Debug.Log("Task1(): Task 1 Finished");
        }

        public void Task2()
        {
            Debug.Log("Task2(): + Task 2 Finished");
        }

        public void Task3()
        {
            Debug.Log("Task3(): Task 3 Finished");
        }
    } 
}
