using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectEvent", menuName = "CardVariables/EffectEvent")]
public class EffectEvent : ScriptableObject
{
    private readonly List<EventListener> listeners = new List<EventListener>();
    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void Register(EventListener listener)
    {
        if(!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }

    public void UnRegister(EventListener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}
