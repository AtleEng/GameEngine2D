using System.Collections.Generic;
using System.Numerics;
using CoreEngine;
using Engine;

namespace Engine
{
    //handles all entities for the components
    public static class EntityManager
    {
        public static void SpawnEntity(GameEntity entity, Vector2 position)
        {
            SpawnEntity(entity, new Transform(position, Vector2.One, 0), null);
        }
        public static void SpawnEntity(GameEntity gameEntity, Transform transform, GameEntity? parent)
        {
            System.Console.WriteLine("Spawning entity");

            gameEntity.worldTransform = transform;
            gameEntity.parent = parent;

            foreach (Component component in gameEntity.components.Values)
            {
                if (component is PhysicsBody physicsBody)
                {
                    physicsBody.position = gameEntity.worldTransform.position;
                }
                component.Start();
            }
            Core.entitiesToAdd.Add(gameEntity);
        }

        public static void DestroyEntity(GameEntity gameEntity)
        {
            foreach (Component component in gameEntity.components.Values)
            {
                component.OnDestroy();
            }
            Core.entitiesToRemove.Add(gameEntity);
        }

    }
}