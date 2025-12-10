using Scenes.GameScene.Features.EntityClasses.BasicEntity;
using Scenes.GameScene.Features.HealthFeatures;
using Unity.VisualScripting;

namespace Scenes.GameScene.Features.CombatFeatures
{
    public class CombatSystem
    {
        private float _damage;
        private float _range;
        private float _rechargeSpeed;
        
        private HealthSystem _healthSystem;
        
        public float SetDamage(float damage)
        { 
            return _damage = damage;
        }
        public float TakeDamage()
        {
           return _healthSystem.SetHealth(_healthSystem.GetHealth() -  _damage);
        }

        public void Attack()
        {
            //FindNearestEnemy(object);
            //WalkToEnemy(object);
            //_healthSystem.TakeDamage();
        }

        public void FindNearestEnemy(Entity entity)
        {
            //
        }
        
        
    }

    
}