using System.Collections.Generic;
using UnityEngine;

public class CardRegistry : MonoBehaviour
{
    // A list to hold all the cards
    private static List<Card> cardList = new List<Card>();

    // Initialized before buildingRegistry
    void Awake()
    {
        // Create the cards
        CreateCard("Python", 100, 150, 20);
        CreateCard("Java", 200, 100, 30);
        CreateCard("C", 150, 200, 40);

        // To test, log the names of the cards that were created
        foreach (var card in cardList)
        {
            Debug.Log("Created card: " + card.getName());
        }
    }

    // Method to create a card and add it to the list
    void CreateCard(string name, int offense, int defense, int staminaCost)
    {
        
        Sprite cardSprite = null; // Card sprite placeholder 

        Card newCard = new Card(cardSprite, name);
        newCard.setOffense(offense);
        newCard.setDefense(defense);
        newCard.setStaminaCost(staminaCost);

        cardList.Add(newCard);
    }

    // Method to get a card by name
    // Might be helpful
    public static Card GetCardByName(string cardName)
    {
        return cardList.Find(card => card.getName() == cardName);
    }
}
