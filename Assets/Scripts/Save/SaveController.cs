using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    private CardSpawner cardSpawner;
    private bool isCardSaved;

    private void Awake()
    {
        cardSpawner = GetComponent<CardSpawner>();
    }

    public bool IsCardSaved { get => isCardSaved; }

    public CardData GetCardInfo()
    {
        return cardSpawner.CurrentCard;
    }

    public void SaveCardInfo()
    {
        SaveData saveData = new SaveData(GetCardInfo());
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(Application.dataPath + "/save.txt", json);
    }

    public SaveData TryLoadCardInfo()
    {
        if (File.Exists(Application.dataPath + "/save.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/save.txt");
            SaveData saveData = JsonUtility.FromJson<SaveData>(saveString);
            isCardSaved = true;
            return saveData;
        }
        else
        {
            isCardSaved = false;
            return null;
        }
    }
}
