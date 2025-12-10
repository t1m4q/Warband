using Scenes.GameScene.Features.CombatFeatures;
using Scenes.GameScene.Features.EntityClasses.BasicEntity;
using Scenes.GameScene.Features.HealthFeatures;
using UnityEngine;

namespace Scenes.GameScene.Features.EntityClasses.Warriors
{
    public class Warrior : MonoBehaviour
    {
        [SerializeField] int hp;
        [SerializeField] int damage;
        
        private Entity _entity;
        private CombatSystem _combatSystem;
        private HealthSystem _healthSystem;

        public void SetAttributes()
        {
            _healthSystem.SetHealth(hp);
            _combatSystem.SetDamage(damage);
        }

    }
}