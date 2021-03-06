﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uno.Players
{
    [Serializable()]
    class Player
    {
        protected string mName;
        protected List<Card> mCards;
        protected int mNumber;
        protected int mFinalScore;

        public Player (int pPlayerNumber, string pPlayerName)
        {
            mNumber = pPlayerNumber;
            mName = pPlayerName;
            mCards = new List<Card>();
            mFinalScore = 0;
        }

        public virtual int FinalScore
        {
            get { return this.mFinalScore; }
            set { this.mFinalScore = value; }
        }

        public virtual List<Card> Cards
        {
            get { return mCards; }
            set { mCards = value; }
        }

        public virtual string Name
        {
            get { return this.mName; }
        }

        /// <summary>
        /// used to give a nice visual display of player objects as strings. 
        /// </summary>
        /// <returns>player name</returns>
        public override string ToString()
        {
            return this.mName;
        }

        /// <summary>
        /// Sorts player cards using improved bubble sort since other than the first run
        /// the cards will be almost sorted with each subsequent use. 
        /// </summary>
        public virtual void SortPlayerCards()
        {
            for (int outIndex = 0; outIndex < mCards.Count; outIndex++)
            {
                bool swapped = false;
                for (int inIndex = 0; inIndex < (mCards.Count - outIndex - 1); inIndex++)
                {
                    if (mCards[inIndex].UniqueIdentifier > mCards[inIndex+1].UniqueIdentifier)
                    {
                        Card tempCard = mCards[inIndex];
                        mCards[inIndex] = mCards[inIndex+1];
                        mCards[inIndex+1] = tempCard;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }      
    }
}
