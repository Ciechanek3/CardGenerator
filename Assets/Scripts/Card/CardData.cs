using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData
{
    private string title;
    private string description;
    private Sprite image;
    private int health;
    private int speed;
    private int mana;

    public string Title { get => title; set => title = value; }
    public string Description { get => description; set => description = value; }
    public Sprite Image { get => image; set => image = value; }
    public int Health { get => health; set => health = value; }
    public int Speed { get => speed; set => speed = value; }
    public int Mana { get => mana; set => mana = value; }
}
