using System.Collections.Generic;
using System.Numerics;
using CoreEngine;
using Engine;

namespace CoreEngine
{
    public class GameEntity
    {
        public string name = "GameEntity";
        public Dictionary<Type, Component> components = new();

        public Transform localTransform = new(Vector2.Zero, Vector2.One, 0);
        public Transform worldTransform = new(Vector2.Zero, Vector2.One, 0);

        public GameEntity? parent;
        public List<GameEntity> children = new();

        public bool HasComponent<T>()
        {
            return components.ContainsKey(typeof(T));
        }
        public T? GetComponent<T>() where T : Component
        {
            if (components.TryGetValue(typeof(T), out var component))
            {
                return (T)component;
            }
            return null;
        }
        public void AddComponent<T>(Component component) where T : Component
        {
            component.gameEntity = this;
            components.Add(typeof(T), component);
        }
        public void RemoveComponent<T>()
        {
            components.Remove(typeof(T));
        }

        public void AddChild(GameEntity child)
        {
            children.Add(child);
            child.SetParent(this);
        }

        public void SetParent(GameEntity newParent)
        {
            if (parent != null)
            {
                parent.children.Remove(this);
            }
            parent = newParent;
            parent.children.Add(this);
        }
    }
}