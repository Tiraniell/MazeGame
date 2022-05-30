using System;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputController _inputController;

        [SerializeField] private GameObject _player;

       void Awake()
        {
            _inputController = new InputController(_player.GetComponent<Unit>());

        }

        void Update()
        {

        }
    }
}