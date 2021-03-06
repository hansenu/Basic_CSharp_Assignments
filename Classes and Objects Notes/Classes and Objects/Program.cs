﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3); //calling the class method shuffle
            /*int timeShuffled = 0;*/ //adding timeShuffled default value
            //added out parameter to verify number of times it shuffled
            //can use named parameter by adding deck: deck, times: 5
            /*deck = Shuffle(deck, out timeShuffled, 5);*/  //calling the method we made below to shuffle, best to use optional parameter to shuffle more
            //deck = Shuffle(deck, 5);  // not the best option to use the method overloading

            //to iterate each card to get all 52, easiest fastest way after making the constructor on Deck class
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count); //Count will show how many in total was instantiated
            /*Console.WriteLine("Times shuffled: {0}", timeShuffled);*/ //used {0} to add variable next to the comma, can use {1} to add another variable

            //deck.Cards = new List<Card>();

            //Add 1 card to a deck, takes a lot of time to do below
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Card cardOne = new Card();

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.ReadLine();
        }

        //added out parameter to count how many times shuffled - out int timeShuffled
        //added int times = 1 as default value, to be shuffled more than once, best option to use optional parameter than method overloading
        
        //shuffle moved to deck for cleaner code

        //another method to reshuffle many times, method overloading, not the best
        //public static Deck Shuffle (Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
