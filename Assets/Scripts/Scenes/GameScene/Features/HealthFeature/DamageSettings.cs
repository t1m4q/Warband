using System;

namespace Scenes.GameScene.Features.HealthFeature
{
    [Serializable]
    public struct DamageSettings
    {
        public int damage;
        public DamageType damageType;

    }

    public enum DamageType
    {
        Physical,
        Magical,
        Pure,
    }
}