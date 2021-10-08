using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command_DP_Practical_Space
{
    public class MoveUpCommand : ICommand
    {
        private Transform _playerTransform;
        private float _speed;

        public MoveUpCommand(Transform playerTransform, float speed)
        {
            this._playerTransform = playerTransform;
            this._speed = speed;
        }

        void ICommand.Execute()
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        void ICommand.Undo()
        {
            // do opposite - moveDown
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

    }

}