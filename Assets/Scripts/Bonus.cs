using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Bonus : MonoBehaviour, IExecute
    {
        private bool _isIntaractable;
        public Transform _transform;
        public bool isIntaractable
        {
            get { return _isIntaractable; }
            private set
            {
                _isIntaractable = value;
                GetComponent<Renderer>().enabled = value;
                GetComponent<Collider>().enabled = value;
            }
        }
        private void Awake()
        {
            _transform = GetComponent<Transform>();
        }

        void Start()
        {
            isIntaractable = true;

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
                isIntaractable = false;
            }
        }
        protected abstract void Interaction();
        public abstract void Update();
        
    }
}
