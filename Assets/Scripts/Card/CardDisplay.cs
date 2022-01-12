using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CardDisplay : MonoBehaviour
{
    [Header("Display fields")]
    [SerializeField]
    private TextMeshProUGUI title;
    [SerializeField]
    private TextMeshProUGUI description;
    [SerializeField]
    private Image image;
    [SerializeField]
    private TextMeshProUGUI health;
    [SerializeField]
    private TextMeshProUGUI speed;
    [SerializeField]
    private TextMeshProUGUI mana;
    [SerializeField]

    public void AssignVariablesToDisplay(CardData data)
    {
        Image = data.Image;
        Health.SetText(data.Health.ToString());
        Speed.SetText(data.Speed.ToString());
        Mana.SetText(data.Mana.ToString());
        Description.SetText(data.Description);
        Title.SetText(data.Title);
    }

    public TextMeshProUGUI Title { get => title; set => title = value; }
    public TextMeshProUGUI Description { get => description; set => description = value; }
    public Sprite Image { get => image.sprite; set => image.sprite = value; }
    public TextMeshProUGUI Health { get => health; set => health = value; }
    public TextMeshProUGUI Speed { get => speed; set => speed = value; }
    public TextMeshProUGUI Mana { get => mana; set => mana = value; }
}
