using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Receiver : MonoBehaviour
{
    [SerializeField]
    private CardSpawner cardSpawner;
    [SerializeField]
    private TextMeshProUGUI healthDisplay;
    [SerializeField]
    private TextMeshProUGUI speedDisplay;
    [SerializeField]
    private TextMeshProUGUI manaDisplay;

    private int health = 10;
    private int speed = 10;
    private int mana = 10;

    private void OnEnable()
    {
        SetValues();
    }

    public void SetValuesAfterEventReceived()
    {
        health += cardSpawner.CurrentCard.Health;
        speed += cardSpawner.CurrentCard.Speed;
        mana += cardSpawner.CurrentCard.Mana;
        SetValues();
        cardSpawner.SpawnFromPool();
    }

    private void SetValues()
    {
        healthDisplay.text = health.ToString();
        speedDisplay.text = speed.ToString();
        manaDisplay.text = mana.ToString();
    }

    
}
