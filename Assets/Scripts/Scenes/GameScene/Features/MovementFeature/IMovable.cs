using Features.HealthFeature;
using UnityEngine;

namespace Scripts.Interfaces
{
    public interface IMovable
    {
        void SetSettings(MovementSettings settings);
        MovementSettings GetSettings();
        void Move();
    }
}