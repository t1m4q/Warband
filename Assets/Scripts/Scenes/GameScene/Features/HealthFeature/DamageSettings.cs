using System;

namespace Features.HealthFeature
{
    [Serializable]
    public struct DamageSettings
    {
        public float damage;
        public DamageType damageType;

    }

    public enum DamageType
    {
        Physical,
        Magical,
        Pure,
    }
}