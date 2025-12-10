using System.Collections.Generic;

namespace Scenes.GameScene.Features.EntityClasses.BasicEntity
{
    public class EntityCollection
    {
        private List<Entity> _entities = new List<Entity>();

        public void AddEntityToCollection(Entity entity)
        {
            _entities.Add(entity);
        }
        
        public void RemoveEntityFromCollection(Entity entity)
        {
            _entities.Remove(entity);
        }
        
    }

    
}