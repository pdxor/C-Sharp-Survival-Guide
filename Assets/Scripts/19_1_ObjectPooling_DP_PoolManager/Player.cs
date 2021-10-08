using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling_DP_PoolManager_Space
{
    public class Player : MonoBehaviour
    {
        //[SerializeField] private GameObject _bulletPrefab;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Instantiate(_bulletPrefab);    // re-use bullets
                // communicate with object pool system
                GameObject bullet = PoolManager.Instance.RequestBullet();

                // request bullet
                bullet.transform.position = Vector3.zero;

            }
        }
    } 
}
