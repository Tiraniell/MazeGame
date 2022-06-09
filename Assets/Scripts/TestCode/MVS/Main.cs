using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVS
{
    public class Main : MonoBehaviour
    {

        [SerializeField] private View _player;
        [SerializeField] private View _triger;

        private Controller _controller;

        private void Awake()
        {
            _controller = new Controller(_player, _triger);
        }

        private void Update()
        {
            _controller.MyUpdate();
        }
    }
}