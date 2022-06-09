using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVS
{
    public class Controller
    {
        private Transform _playerT;
        private View _trigerT;
        private View _playerView;


        public Controller(View player, View triger)
        {
            _playerView = player;
            _playerT = player._transform;
            _trigerT = triger;

            _trigerT.OnLevelObjectContact += ControllerRecieveAction;
        }

        private void ControllerRecieveAction(Collider contactView, int Val, Transform ValT)
        {
            Debug.Log("Обработчик события: Имя объекта в триггере" + contactView.gameObject.name);

            GameObject.Destroy(contactView.gameObject);
        }

        public void MyUpdate()
        {

        }
    }
}