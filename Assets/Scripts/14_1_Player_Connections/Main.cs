using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerConnectionsSpace
{
    public class Player
    {
        public string name;
        public int id;

        public Player(int id)
        {
            this.id = id;
        }
    }

    public class Main : MonoBehaviour
    {
        public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();

        void Start()
        {
            Player p1 = new Player(1);
            p1.name = "Jennifer";
            Player p2 = new Player(2);
            p2.name = "Jocelyn";
            Player p3 = new Player(3);
            p3.name = "Jacqueline";

            playerDictionary.Add(p1.id, p1);
            playerDictionary.Add(p2.id, p2);
            playerDictionary.Add(p3.id, p3);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PrintPlayeConnections();
            }
        }

        public void PrintPlayeConnections()
        {
            foreach (var player in playerDictionary.Values)
            {
                Debug.Log("ID: " + player.id + " Name: " + player.name);

            }
        }
    }

}