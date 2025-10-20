using UnityEngine;
using Scripts.Interfaces;

namespace Scripts.Class.Human
{
    public class Human : IMovable, IDamagable
    {
        private string name;
        private int age;

        public float Speed { get; private set; } = 5f;

        public int Health { get; private set; }
        public int MaxHealth { get; private set; }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public Human(string name, int age, int maxHealth = 100)
        {
            this.name = name;
            this.age = age;

            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        public string GetMoveDescription()
        {
            return $"Человек {name} идет пешком со скоростью {Speed} м/с";
        }

        public void Move()
        {
            Debug.Log($"{name} движется со скоростью {Speed}");
        }


        public void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                Debug.Log($"{name} уже мертв и не может получать урон.");
                return;
            }

            Health -= damage;
            Debug.Log($"{name} получил {damage} урона. Текущее здоровье: {Health}");

            if (Health <= 0)
            {
                Health = 0;
                Debug.Log($"{name} погиб.");
            }
        }

    }
}
