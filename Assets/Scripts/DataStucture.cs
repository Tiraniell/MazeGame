using System;
using UnityEngine;

namespace Maze 
{ 
    [Serializable]
    public struct Svect3
    {
        public float X;
        public float Y;
        public float Z;

        public Svect3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator Svect3(Vector3 val)
        {
            return new Svect3(val.x, val.y, val.z);   
        }

        public static implicit operator Vector3(Svect3 val)
        {
            return new Vector3(val.X, val.Y, val.Z);
        }


    }

    [Serializable]
    public struct SQuater
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public SQuater(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public static implicit operator SQuater(Quaternion val)
        {
            return new SQuater(val.x, val.y, val.z, val.w);
        }

        public static implicit operator Quaternion(SQuater val)
        {
            return new Quaternion(val.X, val.Y, val.Z, val.W);
        }

        [Serializable]
        public struct Sobject
        {
            public string Name;
            public Svect3 Position;
            public SQuater Rotation;
            public Svect3 Scale;
        }

    } 
}


