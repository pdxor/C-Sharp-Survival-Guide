using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunctionMethods
{
    public class PositionMatters : MonoBehaviour
    {
        [SerializeField] private Vector3[] _positions;
        [SerializeField] private int _randomIndex;

        //private void Awake()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        _positions[i] = new Vector3(Random.Range(0, 5f), Random.Range(0, 5f), Random.Range(0, 5f));
        //    }
        //}
        void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                _positions[i] = new Vector3(Random.Range(0, 5f), Random.Range(0, 5f), Random.Range(0, 5f));
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _randomIndex = GetRandomIndex();
                SetPosition(_randomIndex);
            }
        }

        Vector3 GetPosition(int index)
        {
            return _positions[index];
        }

        void SetPosition(int randIndx)
        {
            transform.position = GetPosition(randIndx);
        }

        int GetRandomIndex()
        {
            return Random.Range(0, _positions.Length);
        }
    }
}