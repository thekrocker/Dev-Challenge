using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public abstract class GameEventAbstract<T> : ScriptableObject
{
    public UnityAction<T> OnEventInvoked { get; set; }
    public virtual void InvokeEvent(T t) => OnEventInvoked?.Invoke(t);
    
}
