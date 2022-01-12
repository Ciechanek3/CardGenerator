using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    public string title;
    public string description;
    public Sprite image;
    public int health;
    public int speed;
    public int mana;

    public SaveData(CardData data)
    {
        title = data.Title;
        description = data.Description;
        image = data.Image;
        health = data.Health;
        speed = data.Speed;
        mana = data.Mana;
    }
}
