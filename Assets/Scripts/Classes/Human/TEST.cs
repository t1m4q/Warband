using UnityEngine;
using Scripts.Class.Human;

public class TestHuman : MonoBehaviour
{
    private void Start()
    {
        Human warrior = new Human("�������", 30, 100);

        Debug.Log($"������ �������: {warrior.IsAlive}, ��������: {warrior.Health}");

        warrior.TakeDamage(30);
        Debug.Log($"����� �����: ���? {warrior.IsAlive}, ��������: {warrior.Health}");

        warrior.TakeDamage(80);
        Debug.Log($"����� ������ �����: ���? {warrior.IsAlive}, ��������: {warrior.Health}");

        warrior.TakeDamage(20);
        Debug.Log("������� ������� ���� �������� ���������");
    }
}
