using System;
using UnityEngine;
using UnityEngine.Events;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int maxHp;
    [SerializeField] private UnityEvent <int, int> onHealthChanged;

    private void Start()
    {
        hp = maxHp;
        onHealthChanged.Invoke(hp, maxHp);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        onHealthChanged.Invoke( hp, maxHp);
    }
}
