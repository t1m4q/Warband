using UnityEngine;

namespace Scripts.Interfaces
{
    public interface IDamagable
    {
        int Health { get; }
        int MaxHealth { get; }
        void TakeDamage(int damage);
        bool IsAlive { get; }
    }
}
