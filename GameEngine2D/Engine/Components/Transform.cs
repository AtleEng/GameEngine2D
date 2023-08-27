using System.Numerics;
using System.Collections.Generic;
using CoreEngine;
using Engine;

namespace Engine
{
    public class Transform
    {
        public Transform(Vector2 position, Vector2 size, float rotation)
        {
            this.position = position;
            this.size = size;
            this.rotation = rotation;
        }
        public Vector2 position;
        public Vector2 size;
        public float rotation;
    }
}