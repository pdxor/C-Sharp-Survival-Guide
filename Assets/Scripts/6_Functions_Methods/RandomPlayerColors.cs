using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunctionMethods
{
    public class RandomPlayerColors : MonoBehaviour
    {
        private GameObject[] _players;
        void Start()
        {
            _players = GetAllPlayers();
        }

        void Update()
        {

        }

        GameObject[] GetAllPlayers()
        {
            GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

            foreach (var player in allPlayers)
            {
                player.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
            }
            return allPlayers;
        }
    }
}