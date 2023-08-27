using System.Numerics;
using System.Collections.Generic;
using CoreEngine;
using Engine;

namespace Engine
{
    public class PhysicsBody : Component
    {
        public Vector2 position;
        public Vector2 velocity;
        public Vector2 acceleration;

        public float mass = 1;
        public float elastisity = 0.5f;

        public float viscosity = 0.0f;

        public float gravity = 9.82f;
    }
}