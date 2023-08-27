using System.Collections.Generic;
using System.Numerics;
using CoreEngine;

namespace CoreEngine
{
    public abstract class Component
    {
        public GameEntity gameEntity = new();

        public virtual void Start() { }
        public virtual void Update() { }
        public virtual void OnDestroy() { }

        public virtual void OnTrigger() { }
    }
}