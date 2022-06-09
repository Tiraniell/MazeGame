using System;
using System.Collections.Generic;
using UnityEngine;

namespace MVS
{

    public class View : MonoBehaviour
    {
        [SerializeField] public Transform _transform;
        [SerializeField] public Collider _collider;
        [SerializeField] public Rigidbody _rb;

        public Action<Collider, int, Transform> OnLevelObjectContact { set; get; }


        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);
            Collider LevelObject = other;

            OnLevelObjectContact?.Invoke(LevelObject, 12, LevelObject.transform);
                
        }
    }
}
