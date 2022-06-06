using System.Collections;
using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Maze
{
    public sealed class ListExecutObject : IEnumerator, IEnumerable
    {
        private IExecute[] _intractiveObject;
        private int _index = -1;

        public object Current => _intractiveObject[_index];
        public int Lenght => _intractiveObject.Length;

        public ListExecutObject()
        {
            Bonus[] BonusObject = Object.FindObjectsOfType<Bonus>();
            for (int i = 0; i < BonusObject.Length; i++)
            {
                if(BonusObject[i] is IExecute intObj)
                {
                    AddExecuteObject(intObj);
                }
            }
        }

        public IExecute this[int curr]
        {
            get => _intractiveObject[curr];
            private set => _intractiveObject[curr] = value;
        }

        public void AddExecuteObject(IExecute execute)
        {
            if (_intractiveObject == null)
            {
                _intractiveObject = new[] {execute};
                return;
            }

            Array.Resize(ref _intractiveObject, Lenght+1);
            _intractiveObject[Lenght-1] = execute;

        }

        public bool MoveNext()
        {
            if(_index == Lenght-1)
            {
                Reset();
                return false;
            }
            _index++;
            return true;
            
        }

        public void Reset()
        {
            _index = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
