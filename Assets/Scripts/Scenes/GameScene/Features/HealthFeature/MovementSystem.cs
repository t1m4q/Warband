using Scripts.Interfaces;
using UnityEngine;

namespace Features.HealthFeature
{
    public class MovementSystem : MonoBehaviour, IMovable
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

        public void Move()
        {
            //transform.position = Vector3.MoveTowards(transform.position, _target.position, Time.deltaTime * settings.movementSpeed);
        }
    }
}
