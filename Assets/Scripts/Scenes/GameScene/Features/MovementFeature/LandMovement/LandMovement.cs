using Features.HealthFeature;
using UnityEngine;

namespace Features.LandMovement
{
    public class LandMovement : MonoBehaviour
    {
        [SerializeField] private MovementSystem movementSystem;
        private void OnCollisionEnter(Collision collision)
        {
            var movementSettings = movementSystem.GetSettings();
            movementSettings.movementSpeed *= 2f;
            movementSystem.SetSettings(movementSettings);
        }
    }
}