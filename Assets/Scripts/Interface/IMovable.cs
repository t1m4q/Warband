using UnityEngine;

namespace Scripts.Interfaces
{
    public interface IMovable
    {
        float Speed { get; }
        void Move();
        string GetMoveDescription();
    }
}