using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command_DP_Practical_Space
{
    public class Player : MonoBehaviour
    {
        ICommand moveUp, moveDown, moveLeft, moveRight;

        [SerializeField] private float _speed = 2.0f;

        void Start()
        {
            this.transform.position = Vector3.zero;
        }

        // ToDo: Optimize with generic method
        void Update()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                // move up  command
                moveUp = new MoveUpCommand(this.transform, this._speed);
                moveUp.Execute();
                CommandManager.Instance.AddCommand(moveUp);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                // move down command
                moveDown = new MoveDownCommand(this.transform, this._speed);
                moveDown.Execute();
                CommandManager.Instance.AddCommand(moveDown);
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                // move left command
                moveLeft = new MoveLeftCommand(this.transform, this._speed);
                moveLeft.Execute();
                CommandManager.Instance.AddCommand(moveLeft);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                // move right command
                moveRight = new MoveRightCommand(this.transform, this._speed);
                moveRight.Execute();
                CommandManager.Instance.AddCommand(moveRight);
            }
        }
    } 
}
