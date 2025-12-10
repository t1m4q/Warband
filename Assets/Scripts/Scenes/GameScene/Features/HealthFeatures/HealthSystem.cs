using Scenes.GameScene.Features.CombatFeatures;

namespace Scenes.GameScene.Features.HealthFeatures
{
    public class HealthSystem
    {
        private float _hp;
        private float _maxHp;
        
        public bool IsAlive()
        {
            if (_hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float SetHealth(float hp)
        {
            return _hp = hp;
        }

        public float GetHealth()
        {
            return _hp;
        }
        
    }
}