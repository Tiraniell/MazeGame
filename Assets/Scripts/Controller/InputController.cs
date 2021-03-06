using UnityEngine;

namespace Maze
{
    public class InputController : IExecute
    {
        private readonly Unit _player;

        private float horizontal;
        private float vertical;

        public InputController(Unit player)
        {
            _player = player;
            Debug.Log(_player.name);
        }

        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            _player.Move(horizontal, 0f, vertical);

            if (Input.GetKeyDown(KeyCode.Q))
            {
                _player.SavePlayer();
            }
        }
    }
}
