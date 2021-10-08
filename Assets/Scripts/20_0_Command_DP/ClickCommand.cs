using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command_DP_Space
{
    public class ClickCommand : ICommand
    {
        // constructor
        private GameObject _cube;
        private Color _color;
        private Color _previousColor;

        public ClickCommand(GameObject cube, Color color)
        {
            this._cube = cube;
            this._color = color;
        }
        public void Execute()
        {
            //throw new System.NotImplementedException();   // delete

            // store current color
            _previousColor = _cube.GetComponent<MeshRenderer>().material.color;

            // change cube to random color
            _cube.GetComponent<MeshRenderer>().material.color = _color;
        }

        public void Undo()
        {
            //throw new System.NotImplementedException();   // delete
            _cube.GetComponent<MeshRenderer>().material.color = _previousColor; 
        }
    } 
}
