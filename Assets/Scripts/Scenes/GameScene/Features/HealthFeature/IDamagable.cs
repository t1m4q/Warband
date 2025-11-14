using Scenes.GameScene.Features.HealthFeature;

namespace Features.HealthFeature
{
    public interface IDamagable
    {
        int Health { get; }
        int MaxHealth { get; }
        void TakeDamage(DamageSettings settings);
        void Healing(int heal);
        bool IsAlive { get; }
    }
}
