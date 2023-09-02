using System.Collections.Generic;
using System.Numerics;
using CoreEngine;
using Engine;

namespace CoreEngine
{
    public static class Core
    {
        public static bool shouldClose;

        // Define the update order for systems
        static public List<GameSystem> updateOrder = new List<GameSystem>
        {
        //basic systems
            new ScriptSystem(),
            new TransformSystem(),

            //physics systems
            new TriggerSystem(),
            new CollisionSystem(),
            new PhysicsSystem(),

            //grahpics systems
            new RenderSystem()
            
            //audio systems
        };
        static public List<GameEntity> activeEntities = new();

        static public List<GameEntity> entitiesToAdd = new();
        static public List<GameEntity> entitiesToRemove = new();

        public static void Innit()
        {

            // Innit all the systems in the right order
            for (int i = 0; i < updateOrder.Count; i++)
            {
                updateOrder[i].Start();
            }
            while (shouldClose == false)
            {
                Time.UpdateDeltaTime();
                UpdateSystems();
            }
        }
        static void UpdateSystems()
        {


            // Batched lists for adding and removing entities
            List<GameEntity> entitiesToAddBatch = new List<GameEntity>();
            List<GameEntity> entitiesToRemoveBatch = new List<GameEntity>();

            // Iterate through systems in the specified order
            foreach (var system in updateOrder)
            {
                system.Update();
            }

            // Apply batched entity additions and removals
            foreach (var entity in entitiesToAddBatch)
            {
                activeEntities.Add(entity);
            }
            foreach (var entity in entitiesToRemoveBatch)
            {
                activeEntities.Remove(entity);
            }

            // Clear the batched lists
            entitiesToAddBatch.Clear();
            entitiesToRemoveBatch.Clear();
        }
    }
}