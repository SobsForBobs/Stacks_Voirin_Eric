using System;
using System.Collections.Generic;

namespace Stacks_Voirin_Eric
{
    class Program
    {
        static void Main(string[] args)
        {// Create a stack of cards
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Hearts"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds")
            };

            // Create a stack of cards using the array
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
            // Display the number of cards in the deck
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");
            // Create a list of cards to represent the player's hand
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            Console.WriteLine("Got any 8's?");
            if(startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }
            // Display the number of cards in the deck
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");
            // Display the cards in the player's hand
            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            // Display the cards in the deck
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

        }
    }
}
