using UnityEngine;

namespace EnemyUISpawnCountSpace
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyPrefab;

        public static int enemyCount;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
                Instantiate(_enemyPrefab);
                enemyCount++;
            }
        }
    }
}
