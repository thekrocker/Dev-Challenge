using UnityEngine;
using UnityEngine.Events;

namespace Project.Flexible_Events.Scripts.Variation_2
{
    [CreateAssetMenu(menuName = "Events/GameEvent")]
    public class GameEventSO : ScriptableObject
    {
        public UnityAction OnEventInvoked { get; set; }
        public void InvokeEvent() => OnEventInvoked?.Invoke();
    }
}