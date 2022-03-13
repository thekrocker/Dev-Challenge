using System;
using UnityEngine;

namespace Project.Flexible_Events.Scripts.Variation_2
{
    public class ColorChanger : MonoBehaviour
    {
        [SerializeField] private GameEventAbstract<int> onEnemyDied;
        private MeshRenderer _mesh;

        private void OnEnable() => onEnemyDied.OnEventInvoked += SetMeshColor;

        private void OnDisable() => onEnemyDied.OnEventInvoked -= SetMeshColor;

        private void SetMeshColor(int health)
        {
            Debug.Log(health);
        }
    }
}