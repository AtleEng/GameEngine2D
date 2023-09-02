using System.Collections.Generic;
using System.Numerics;
using CoreEngine;

namespace CoreEngine
{
    public class TransformSystem : GameSystem
    {
        public override void Start()
        {

        }
        public override void Update()
        {
            foreach (GameEntity gameEntity in Core.activeEntities)
            {
                foreach (GameEntity child in gameEntity.children)
                {
                    child.parent = gameEntity;

                    /*set position*/
                    child.worldTransform.position = gameEntity.worldTransform.position + child.localTransform.position;
                    /*set size*/
                    child.worldTransform.size = gameEntity.worldTransform.size + child.localTransform.size;
                    /*set rotation*/
                    child.worldTransform.rotation = gameEntity.worldTransform.rotation + child.localTransform.rotation;
                }
            }
        }
    }
}