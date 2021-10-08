using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command_DP_Practical_Space
{
    public class MoveDownCommand : ICommand
    {
        private Transform _playerTransform;
        private float _speed;

        public MoveDownCommand(Transform playerTransform, float speed)
        {
            this._playerTransform = playerTransform;
            this._speed = speed;
        }

        void ICommand.Execute()
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        void ICommand.Undo()
        {
            // do opposite - moveUp
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

    }

}