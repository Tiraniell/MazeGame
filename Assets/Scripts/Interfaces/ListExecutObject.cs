using System.Collections;
using System;
using UnityEngine;

namespace Maze
{
    public sealed class ListExecutObject : IEnumerator, IEnumerable
    {
        private IExecute[] _intractiveObject;
        private int _index = -1;

        public object Current => _intractiveObject[_index];

        void Start()
        {

        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {

        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
        void Update()
        {

        }
    }
}
