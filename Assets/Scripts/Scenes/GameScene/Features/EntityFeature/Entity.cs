using System.Collections.Generic;
using Features.HealthFeature;
using Features.MovementFeature;
using UnityEngine;

namespace Scenes.GameScene.Features.EntityFeature
{
    public class Entity : MonoBehaviour
    {
        
        //public HealthSystem healthSystem => healthSystem; так со всеми от iSystem 
        public HealthSystem HealthSystem => healthSystem;
        private int _id;
        
        [SerializeField] private MovementSystem movementSystem;
        [SerializeField] private HealthSystem healthSystem;
        [SerializeField] private FightSystem.FightSystem fightSystem;

        public void SetWorldEntitys(List<Entity> worldEntities)
        {
            fightSystem.SetWorldEntitys(worldEntities);
        }
        private void Start()
        {
            //if (healthSystem.Health < 10)
            //{
            //  movementSystem.RunAway();
            //}
            
            //if (healthSystem.Health > 50)
            //{
            //  fightSystem.fight();
            //}
        }
    }
}
