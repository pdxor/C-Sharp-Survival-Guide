using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling_DP_Space
{
    public class Bullet : MonoBehaviour
    {
        void Start()
        {
            Destroy(this.gameObject, 1f);
        }
    } 
}
