using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public struct PlayerData
    {
        public string PlayerName;
        public int PlayerHealth;
        public bool PlayerDead;
        public Svect3 PlayerPosition;
    }

    public sealed class Player : Unit
    {
        PlayerData SinglePlayerData = new PlayerData();

        private ISaveData _data;

        [SerializeField] Transform PlayerDot;


        private void Awake()
        {
            _transform = transform;

            if (GetComponent<Rigidbody>())
            {
                _rb = GetComponent<Rigidbody>();
            }

            isDead = false;
            Health = 100;

            SinglePlayerData.PlayerHealth = Health;
            SinglePlayerData.PlayerDead = isDead;
            SinglePlayerData.PlayerName = gameObject.name;

            _data = new XMLData();
            

        }

        public override void Move(float x, float y, float z)
        {
            if (_rb)
            {
                _rb.AddForce(new Vector3(-x, y, -z) * speed);
            }
            else
            {
                Debug.Log("No Rigibody");
            }

            PlayerDot.position = new Vector3(transform.position.x, PlayerDot.position.y, transform.position.z);

            SinglePlayerData.PlayerPosition = _transform.position;
        }

        public override void SavePlayer()
        {
            _data.SaveData(SinglePlayerData);
            PlayerData NewPlayer = _data.Load();


            Debug.Log(NewPlayer.PlayerHealth);
            Debug.Log(NewPlayer.PlayerPosition);
            Debug.Log(NewPlayer.PlayerName);
        }
    }
}
