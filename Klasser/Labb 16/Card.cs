using System;

namespace Labb_16
{

    public class Card
    {
        private int Value { get;set;}
        private SuitType Suit { get;set;}
        private int BlackJackValue { get; set;}
        public Card(int _value, SuitType _suit)
        {
            Value = _value;
            Suit = _suit;
        }
        
    }
}