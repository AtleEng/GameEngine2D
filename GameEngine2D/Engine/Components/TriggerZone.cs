using System.Numerics;
using System.Collections.Generic;
using CoreEngine;
using Engine;

namespace Engine
{
    public class TriggerZone : Component
    {
        public Vector2 localPos = new();
        public Vector2 size = Vector2.One;
    }
}