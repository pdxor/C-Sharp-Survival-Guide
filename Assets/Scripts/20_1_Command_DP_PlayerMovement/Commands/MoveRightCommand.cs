using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command_DP_Practical_Space
{
    public class MoveRightCommand : ICommand
    {
        private Transform _playerTransform;
        private float _speed;

        public MoveRightCommand(Transform playerTransform, float speed)
        {
            this._playerTransform = playerTransform;
            this._speed = speed;
        }

        void ICommand.Execute()
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        void ICommand.Undo()
        {
            // do opposite - moveLeft
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

    }

}