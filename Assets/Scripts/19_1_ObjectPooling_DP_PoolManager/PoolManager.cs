using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling_DP_PoolManager_Space
{
    public class PoolManager : MonoBehaviour
    {
        // turn this class into a singleton for easy accessibility
        // use private and public instance/Instance properties
        private static PoolManager _instance;
        public static PoolManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    Debug.LogError("PoolManager::Instance: The Pool Manager instance is NULL");
                    return null;
                }
                else
                {
                    return _instance;
                }
            }
        }

        [SerializeField] private GameObject _bulletContainer;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private List<GameObject> _bulletPool;
        [SerializeField] private int _maxBullets = 10;

        private void Awake()
        {
            _instance = this;
        }

        private void Start()
        {
            _bulletPool = GenerateBullets(_maxBullets);
        }

        // pregenerate a list of bullets using the bullet prefab
        private List<GameObject> GenerateBullets(int amountOfBullets)
        {
            for (int i = 0; i < amountOfBullets; i++)
            {
                GameObject bullet = Instantiate(_bulletPrefab);
                bullet.transform.parent = _bulletContainer.transform;
                bullet.SetActive(false);
                _bulletPool.Add(bullet);
            }
            return _bulletPool;   // list of bullets
        }

        public GameObject RequestBullet()
        {
            // loop through the bullet list
            foreach (var bullet in _bulletPool)
            {
                // check for inactive bullet
                if (bullet.activeInHierarchy == false)
                {
                    // bullet is available
                    // set it active and return it to player
                    bullet.SetActive(true);
                    return bullet;
                }
            }

            // add additional bullets to the pool:
            // if none available (all are already active)
            // generate x amount of bullets and run the request bullet method again

            GameObject newBullet = Instantiate(_bulletPrefab);
            newBullet.transform.parent = _bulletContainer.transform;
            //newBullet.SetActive(true);   // default
            _bulletPool.Add(newBullet);

            return newBullet;
        }

    } 
}
