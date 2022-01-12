using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    [SerializeField]
    private EffectEvent effectEvent;
    [SerializeField]
    private UnityEvent response;

    public void OnEventRaised()
    {
        response.Invoke();
    }

    private void OnEnable()
    {
        effectEvent.Register(this);
    }

    private void OnDisable()
    {
        effectEvent.UnRegister(this);
    }
}
