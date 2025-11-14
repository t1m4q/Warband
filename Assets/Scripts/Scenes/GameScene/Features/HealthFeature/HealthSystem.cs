using Scenes.GameScene.Features.EntityFeature;
using Scenes.GameScene.Features.HealthFeature;
using UnityEngine;

namespace Features.HealthFeature
{
    public class HealthSystem : BaseSystem, IDamagable
    {
        [SerializeField] private int maxHealth;
        
        private int _health;

        public int Health
        {
            get { return _health; } 
        }
        public int MaxHealth 
        {
            get { return maxHealth; }
        }
        public bool IsAlive
        {
            get { return _health > 0; }
        }
        public void TakeDamage(DamageSettings settings)
        {
            _health -= settings.damage;
        }

        public void Healing(int heal)
        {
            _health += heal;
        }

    }
}
