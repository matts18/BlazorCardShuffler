using System;
using System.Collections.Generic;

namespace TwoDecksBlazor
{
    class Deck : List<Card>
    {
        private static Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            Clear();
            for(int suitValue = 0; suitValue < 4; suitValue++)
            {
                for(int cardValue = 1; cardValue <= 13; cardValue++)
                {
                    Add(new Card((Values)cardValue,(Suits)suitValue));
                }
            }
        }

        public void Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            while(copy.Count > 0)
            {
                int randomIndex = random.Next(copy.Count);
                Add(copy[randomIndex]);
                copy.RemoveAt(randomIndex);
            }
        }

        public Card Deal(int index)
        {
            Card card = base[index];
            RemoveAt(index);
            return card;
        }
    }
}
