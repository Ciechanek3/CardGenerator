using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardGenerator", menuName = "CardVariables/CardGenerator")]
public class CardGenerator : ScriptableObject
{
    [Header("Lists with random data ")]
    [SerializeField]
    private CardImages cardImages;
    [SerializeField]
    private CardEffects cardEffects;
    [SerializeField]
    private CardDescriptions cardDescriptions;
    [SerializeField]
    private CardTitles cardTitles;

    public void AssignRandomVariables(CardData data)
    {
        data.Image = cardImages.images[GetRandomNumber(cardImages.images.Count)];
        data.Health = cardEffects.health[GetRandomNumber(cardEffects.health.Count)];
        data.Speed = cardEffects.speed[GetRandomNumber(cardEffects.speed.Count)];
        data.Mana = cardEffects.mana[GetRandomNumber(cardEffects.mana.Count)];
        data.Description = cardDescriptions.descriptions[GetRandomNumber(cardDescriptions.descriptions.Count)];
        data.Title = cardTitles.titles[GetRandomNumber(cardTitles.titles.Count)];
    }

    public int GetRandomNumber(int numberRange)
    {
        return Random.Range(0, numberRange);
    }
}
