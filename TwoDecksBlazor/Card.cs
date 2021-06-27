﻿using System;
namespace TwoDecksBlazor
{
    class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }
        public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
