using System;
using System.Collections.Generic;

namespace Labb_16
{
    public class Deck
    {
        private int nrOfDecks { get; set;}
        private List<Card> lista = new List<Card>();

        public Deck(int _nrofdeck)
        {
            nrOfDecks = _nrofdeck;
        }

        public void ResetAndShuffel()
        {

        }

        public void Shuffel()
        {

        }

        public Card Draw()
        {
            return null;
        }
    }
}