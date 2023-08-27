using System.Collections.Generic;
using System.Numerics;
using CoreEngine;

namespace CoreEngine
{
    public abstract class GameSystem
    {
        public virtual void InnitSystem() { }
        public virtual void Update() { }
    }
}