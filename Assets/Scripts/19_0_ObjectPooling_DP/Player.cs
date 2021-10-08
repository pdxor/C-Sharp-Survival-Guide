using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling_DP_Space
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPrefab;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(_bulletPrefab);
            }
        }
    } 
}
