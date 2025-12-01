using Scenes.GameScene.Features.CombatFeatures;
using Scenes.GameScene.Features.EntityClasses.BasicEntity;
using UnityEngine;

namespace Scenes.GameScene.Features.EntityClasses.Warriors
{
    public class Rookie : MonoBehaviour
    {
        private Entity entity;
        private EntityCombat entityCombat;

        public Rookie()
        {
            entity = new Entity { Hp = 100, Speed = 15 };
            entityCombat = new EntityCombat { EntityDamage = 5 };
        }

    }
}