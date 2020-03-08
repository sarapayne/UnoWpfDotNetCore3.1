﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Image = System.Windows.Controls.Image;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Uno
{
    class Deck
    {
        static string mCardDeckFileName = "CardDeck.bin";
        private List<Card> mDrawPile;
        private List<Card> mDiscardPile;
        private int mUniqueIdentifier;

        public Deck()
        {
            this.mDiscardPile = LoadFullCardDeck();//add cards to the discard originally so it works with refresh piles correctly
            this.mDrawPile = new List<Card>();
            mUniqueIdentifier = 0;
        }

        public List<Card> DrawPile
        {
            get { return this.mDrawPile; }
            set { this.mDrawPile = value; }
        }

        public List<Card> DiscardPile
        {
            get { return this.mDiscardPile; }
            set { this.mDiscardPile = value; }
        }

        public void RefreshCardPiles()
        {
            ShuffleDeck(mDiscardPile);
            mDrawPile = new List<Card>();
            mDrawPile = mDiscardPile;
            mDiscardPile = new List<Card>();
            mDiscardPile.Add(mDrawPile[0]);
            mDrawPile.RemoveAt(0);
        }

        public void ShuffleDeck(List<Card> pDeck)
        {
            Random random = new Random();
            for (int cardIndex = 0; cardIndex < pDeck.Count; cardIndex++)
            {
                int swapIndex = random.Next(0, pDeck.Count - 1);
                Card temp = pDeck[cardIndex];
                pDeck[cardIndex] = pDeck[swapIndex];
                pDeck[swapIndex] = temp;
            }
        }

        private List<Card> LoadFullCardDeck()
        {
            List<Card> newDeck = new List<Card>();
            try
            {
                using (Stream stream = File.Open(mCardDeckFileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    newDeck = (List<Card>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error loading saved settings, generating new settings, if this is the first time you used this software, this is to be expected", "Dictionary load error");
                GenerateCardList(newDeck);
            }
            //GenerateCardList(newDeck);
            return newDeck;
        }

        private void GenerateCardList(List<Card> pCardList)
        {
            List<Suit> suites = new List<Suit> { Suit.Red, Suit.Green, Suit.Blue, Suit.Yellow };
            foreach (Suit suit in suites)
            {
                string colour = "";
                switch (suit)
                {
                    case Suit.Red:
                        colour = "red";
                        break;
                    case Suit.Green:
                        colour = "green";
                        break;
                    case Suit.Blue:
                        colour = "blue";
                        break;
                    case Suit.Yellow:
                        colour = "yellow";
                        break;
                }
                GenerateSuitCards(pCardList, suit, colour);
            }
            GenerateWildCards(pCardList);
            SaveFullCardDeck(pCardList);
        }

        private int UniqueIdentifier()
        {   //ever time this is called increment then return the number before it was incremented. 
            mUniqueIdentifier++;
            return (mUniqueIdentifier - 1);
        }

        private void GenerateWildCards(List<Card> pCardList)
        {
            string imageStandardName = "card_front_wild_standard";
            string imagePickupName = "card_front_wild_pickup";
            CardWild cardWildStandard = new CardWild(imageStandardName, UniqueIdentifier(), 0);
            CardWild cardWildPickup = new CardWild(imagePickupName, UniqueIdentifier(), 4);
            Add2OfEachCardToDeck(pCardList, cardWildStandard);
            Add2OfEachCardToDeck(pCardList, cardWildStandard);
            Add2OfEachCardToDeck(pCardList, cardWildPickup);
            Add2OfEachCardToDeck(pCardList, cardWildPickup);
        }

        //**left here incase another gui needs this as it works. 
        //private Image GetBitmap(string pName)
        //{   //Code Source Microsoft https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.image.source?redirectedfrom=MSDN&view=netframework-4.8#System_Windows_Controls_Image_Source
        //    Image image = new Image();
        //    BitmapImage bitmap = new BitmapImage();
        //    bitmap.BeginInit();
        //    bitmap.UriSource = new Uri(pName, UriKind.Relative);
        //    bitmap.EndInit();
        //    image.Stretch = Stretch.Fill;
        //    image.Source = bitmap;
        //    return image;
        //}

        private void GenerateSuitCards(List<Card> pCardList, Suit pSuit, string pColour)
        {
            GenerateNumberCards(pCardList, pSuit, pColour);
            GenerateSpecialCards(pCardList, pSuit, pColour);
        }

        private void GenerateSpecialCards(List<Card> pCardList, Suit pSuit, string pColour)
        {
            List<SpecialType> specialTypes = new List<SpecialType> { SpecialType.Draw, SpecialType.Reverse, SpecialType.Skip };
            foreach (SpecialType specialType in specialTypes)
            {
                string tail = "";
                switch (specialType)
                {
                    case SpecialType.Draw:
                        tail = "draw";
                        break;
                    case SpecialType.Reverse:
                        tail = "reverse";
                        break;
                    case SpecialType.Skip:
                        tail = "skip";
                        break;
                }
                string imgFileName = "card_front_suit_" + pColour + "_" + tail;
                CardSpecial cardSpecial = new CardSpecial(imgFileName, UniqueIdentifier(), pSuit, specialType);
                Add2OfEachCardToDeck(pCardList, cardSpecial);
            }
        }

        private void GenerateNumberCards(List<Card> pCardList, Suit pSuit, string pColour)
        {
            for (int number = 0; number <= 9; number++)
            {
                string imgFileName = "card_front_suit_" + pColour + "_" + number.ToString();
                CardNumber cardNumber = new CardNumber(imgFileName, UniqueIdentifier(), pSuit, number);
                if (number == 0)
                {
                    pCardList.Add(cardNumber);
                }
                else
                {
                    Add2OfEachCardToDeck(pCardList, cardNumber);
                }
            }
        }

        private void Add2OfEachCardToDeck(List<Card> CardList, Card card)
        {
            CardList.Add(card);
            CardList.Add(card);
        }

        private void SaveFullCardDeck(List<Card> pCardList)
        {
            try
            {
                using (Stream stream = File.Open(mCardDeckFileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, pCardList);
                }
            }
            catch
            {
                MessageBox.Show("Sorry there was an error saving the setup files, is the drive writable?", "Save deck error");
            }
        }
    }
}
