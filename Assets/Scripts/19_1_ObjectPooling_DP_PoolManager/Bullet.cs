using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling_DP_PoolManager_Space
{
    public class Bullet : MonoBehaviour
    {
        //void Start()
        //{
        //    //Destroy(this.gameObject, 1f);
        //}

        // when game object is activated
        private void OnEnable()
        {
            Invoke("Hide", 1f);
        }

        void Hide()
        {
            // need to recycle
            Debug.Log("Hiding Game Object: Bullet");
            this.gameObject.SetActive(false);
        }
    } 
}
