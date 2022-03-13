using System.Collections;
using System.Collections.Generic;
using Project.Flexible_Events.Scripts.Variation_2;
using UnityEngine;

public class EnemyActions : MonoBehaviour
{
    [SerializeField] private GameEventAbstract<int> onDied;
    public int health = 50;
    
    [ContextMenu("Damage Yourself")]
    public void Damage()
    {
        health -= 20;
        if (health > 0) return;
        health = 2;
        onDied.InvokeEvent(health);
    }
}