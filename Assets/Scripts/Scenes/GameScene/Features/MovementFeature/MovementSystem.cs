using Scenes.GameScene.Features.EntityFeature;
using Scripts.Interfaces;
using UnityEngine;

namespace Features.MovementFeature
{
    public class MovementSystem : BaseSystem, IMovable
    {
        [SerializeField] private MovementSettings settings;

        private void Update()
        {
            Move();
        }

        public void SetSettings(MovementSettings newSettings)
        {
            settings = newSettings;
        }

        public MovementSettings GetSettings()
        {
            return settings;
        }

        // SetTargetPosition эту точку будет ставить FightSystem
        public void Move()
        {
            //transform.position = Vector3.MoveTowards(transform.position, _target.position, Time.deltaTime * settings.movementSpeed);
        }
    }
}
