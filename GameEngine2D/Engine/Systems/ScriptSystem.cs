using System.Collections.Generic;
using System.Numerics;
using CoreEngine;

namespace CoreEngine
{
    public class ScriptSystem : GameSystem
    {
        public override void InnitSystem()
        {

        }
        public override void Update()
        {
            foreach (GameEntity gameEntity in Core.gameEntities)
            {
                foreach (Component component in gameEntity.components.Values)
                {
                    component.Update();
                }
            }
        }
    }
}