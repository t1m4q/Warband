using Features.HealthFeature;
using UnityEngine;

namespace Features.Entity
{
    public class Entity : MonoBehaviour
    {
        private int _id;
        
        [SerializeField] private MovementSystem movementSystem;
        //[SerializeField] private HealthSystem healthSystem;
        //[SerializeField] private FightSystem fightSystem;

        private void Start()
        {
            //if (healthSystem.Health < 10)
            //{
            //  movementSystem.RunAway();
            //}
            
            //if (healthSystem.Health > 50)
            //{
            //  fightSystem.fight();
            //}
        }
    }
}
