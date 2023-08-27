using System.Numerics;
using System.Collections.Generic;
using CoreEngine;
using Engine;

namespace Engine
{
    public class ColliderComponent : Component
    {
        Vector2[] worldPoints;
        Vector2 offsetPos;
        float angle;
        Vector2[] originPoints;
        bool isOverlaping;
    }
}