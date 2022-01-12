using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardEffects", menuName = "CardVariables/CardEffects")]
public class CardEffects : ScriptableObject
{
    public List<int> health;
    public List<int> speed;
    public List<int> mana;
}
