using UnityEngine;

namespace Scenes.GameScene.Features.EntityFeature
{
    public class BaseSystem : MonoBehaviour, ISystem
    {
        protected Entity Entity;
        
        public void SetEntity(Entity entity)
        {
            Entity = entity;
        }
    }
}