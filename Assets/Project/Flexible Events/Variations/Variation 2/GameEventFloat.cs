using UnityEngine;

namespace Project.Flexible_Events.Scripts.Variation_2
{
    
    [CreateAssetMenu(fileName = "Abstract Events/Events")]
    public class GameEventFloat : GameEventAbstract<int>
    {
        public override void InvokeEvent(int t)
        {
            base.InvokeEvent(t);
        }
    }
}