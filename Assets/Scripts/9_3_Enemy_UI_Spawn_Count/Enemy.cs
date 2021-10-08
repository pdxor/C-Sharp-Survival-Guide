using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyUISpawnCountSpace
{

    public class Enemy : MonoBehaviour
    {
        private UIManager _ui;

        public void OnEnable()
        {
            SpawnManager.enemyCount++;
            _ui = GameObject.Find("UI_Manager").GetComponent<UIManager>();
            _ui.UpdateEnemyCount();
            Die();   // will call OnDisable()
        }

        public void OnDisable()
        {
            SpawnManager.enemyCount--;
            _ui.UpdateEnemyCount();
        }

        void Die()
        {
            Destroy(this.gameObject, Random.Range(2, 6));
        }
    }

}