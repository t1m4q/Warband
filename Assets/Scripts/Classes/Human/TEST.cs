using UnityEngine;
using Scripts.Class.Human;

public class TestHuman : MonoBehaviour
{
    private void Start()
    {
        Human warrior = new Human("Алексей", 30, 100);

        Debug.Log($"Создан человек: {warrior.IsAlive}, здоровье: {warrior.Health}");

        warrior.TakeDamage(30);
        Debug.Log($"После атаки: жив? {warrior.IsAlive}, здоровье: {warrior.Health}");

        warrior.TakeDamage(80);
        Debug.Log($"После второй атаки: жив? {warrior.IsAlive}, здоровье: {warrior.Health}");

        warrior.TakeDamage(20);
        Debug.Log("Попытка нанести урон мертвому персонажу");
    }
}
