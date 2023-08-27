using System.Collections.Generic;
using System.Numerics;
using CoreEngine;

namespace CoreEngine
{
    public static class Core
    {
        static public List<GameEntity> gameEntities = new();
        static public List<GameSystem> systems = new();

        static public List<GameEntity> entitiesToAdd = new();
        static public List<GameEntity> entitiesToRemove = new();

        public static void Innit()
        {
            systems.Add(new ScriptSystem());
            systems.Add(new TriggerSystem());
            systems.Add(new PhysicsSystem());
            systems.Add(new RenderSystem());
        }
        public static void UpdateSystems()
        {
            // Uppdate all the systems in the right order
            for (int i = 0; i < systems.Count; i++)
            {
                systems[i].Update();
            }

            // Add and remove games entities
            foreach (var entity in entitiesToAdd)
            {
                gameEntities.Add(entity);
            }
            foreach (var entity in entitiesToRemove)
            {
                gameEntities.Remove(entity);
            }
            //clear the lists
            entitiesToAdd.Clear();
            entitiesToRemove.Clear();
        }
    }
}