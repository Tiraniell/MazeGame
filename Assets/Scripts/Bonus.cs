using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Bonus : MonoBehaviour, IExecute
    {
        private bool _isIntaractable;
        public Transform _transform;
        protected Color _color;

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
      

        void Start()
        {
            isIntaractable = true;

            _color = Random.ColorHSV();

            if(TryGetComponent(out Renderer renderer))
            {
                renderer.sharedMaterial.color = _color;
            }

        }

        private void OnTriggerEnter(Collider other)
        {
            if (isIntaractable||other.CompareTag("Player"))
            {
                Interaction();
                isIntaractable = false;
            }
        }
        protected abstract void Interaction();
        public abstract void Update();
        
    }
}
