using UnityEngine;
using System.Collections.Generic;

public class CardSpawner : MonoBehaviour, IObjectPooler
{
    [Header("Random card data generator")]
    [SerializeField]
    private CardGenerator cardGenerator;

    [SerializeField]
    private Canvas mainCanvas;
    [SerializeField]
    private Transform cardPosition;
    
    public Queue<CardDisplay> displayableCards;

    private CardData currentCard = new CardData();
    private SaveController saveController;
    private CardPool cardPool;

    public CardData CurrentCard { get => currentCard; set => currentCard = value; }

    private void Awake()
    {
        saveController = GetComponent<SaveController>();
        cardPool = GetComponent<CardPool>();
        displayableCards = new Queue<CardDisplay>();   

        for (int i = 0; i < cardPool.poolSize; i++)
        {
            CardDisplay obj = Instantiate(cardPool.cardPrefab);
            obj.gameObject.transform.SetParent(mainCanvas.transform);
            obj.gameObject.SetActive(false);
            displayableCards.Enqueue(obj);
        }

        TryLoadCardInfo();
    }

    public void SpawnFromPool()
    {
        foreach(CardDisplay cardDisplay in displayableCards)
        {
            cardDisplay.gameObject.SetActive(false);
        }
        CardDisplay card = displayableCards.Dequeue();

        CreateCard(currentCard);
        card.AssignVariablesToDisplay(currentCard);
        card.gameObject.SetActive(true);        
        card.transform.position = cardPosition.position;       

        displayableCards.Enqueue(card);
    }

    public void CreateCard(CardData data)
    {
        cardGenerator.AssignRandomVariables(data);
    }

    public void OnGenerateButtonClick()
    {
        SpawnFromPool();
    }

    public void TryLoadCardInfo()
    {
        if (saveController.TryLoadCardInfo() != null)
        {
            AssignLoadedCardParameters(saveController.TryLoadCardInfo());
        } 
        
        if(saveController.IsCardSaved)
        {            
            CardDisplay card = displayableCards.Dequeue();           
            card.AssignVariablesToDisplay(currentCard);
            card.gameObject.SetActive(true);
            card.transform.position = cardPosition.position;
        }
    }

    public void AssignLoadedCardParameters(SaveData saveData)
    {
        currentCard.Title = saveData.title;
        currentCard.Description = saveData.description;
        currentCard.Image = saveData.image;
        currentCard.Health = saveData.health;
        currentCard.Speed = saveData.speed;
        currentCard.Mana = saveData.mana;
    }
}
