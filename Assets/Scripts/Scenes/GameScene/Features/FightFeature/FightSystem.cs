using System.Collections.Generic;
using Scenes.GameScene.Features.EntityFeature;
using Scenes.GameScene.Features.Fight;
using Scenes.GameScene.Features.HealthFeature;
using UnityEngine;

namespace Scenes.GameScene.Features.FightSystem
{
    public class FightSystem : BaseSystem
    {
        [SerializeField] private DamageSettings damageSettings;
        

        // Передать сюда список контейнер юнитов, переделать логику

        // Находит точку и передаёт в movement system // МУВ СИСТЕМ ЧТОБЫ ДВИГАЛАСЬ К ТОЧКЕ
        // Vector3.Distance(x,y)
        // FightSettings (скорость атаки дистанция)
        // Удаление объекта при 0 хп
        
        public void SetWorldEntitys(List<Entity> worldEntities)
        {
            
        }
        
    }
}