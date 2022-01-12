using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoActionController : MonoBehaviour
{
    [SerializeField]
    private EffectEvent effectEvent;

    public void OnDoActionButtonPressed()
    {
        effectEvent.Raise();
    }
}
