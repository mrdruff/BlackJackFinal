using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackFinalProject
{
   class Shoe
   {
      //sync shoe
      private Card[] _shoeCards = new Card[312];
      // Constructor
      public Shoe()
      {
         #region ShoeSolution

         CreateShoe();
         this.Shuffle();

         #endregion
      }

      #region Methods
      /// <summary>
      /// Creating 6 decks of 52 cards for a BlackJack Shoe object
      /// This code is called when objected is instantiated
      /// </summary>
      private void CreateShoe()
      {
         // arrays to create cards
         string[] suits = { "hearts", "clubs", "spades", "diamonds" };
         string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                             "Jack", "Queen", "King", "Ace" };
         int counter = 0;
         int cardIndexValue = 0;
         for (int d = 0; d < 6; d++)   // loop for 6 decks
         {
            for (int i = 0; i < 4; i++) // loop for suits
            {
               for (int j = 0; j < 13; j++) // loop for faces
               {
                  // creating a new Card object and storing that in the shoeCards array
                  _shoeCards[counter] = new Card(faces[j], suits[i], cardIndexValue);
                  counter++;
                  cardIndexValue++;
               }
            }
            cardIndexValue = 0;
         }
      }
       public void Shuffle()
      {

           Card temp; // Variable to temporarely store first cards value
           Random rand = new Random(); // Creates random object
           int r; // Variable to store random number

           // Shuffling cards by storing a card in a temporary variable while switching two card values
           for(int i = 0; i < 312; i++)
           {
               r = rand.Next(312);
               temp = _shoeCards[i];
               _shoeCards[i] = _shoeCards[r];
               _shoeCards[r] = temp;

           }
      }
      #endregion

      #region Properties
      // Shoe properties
      public Card[] ShoeCards
      {
         get
         {
            return _shoeCards;
         }
      } 
      #endregion
      #region ShoeSolution
      //public Card SelectedCard(int i)
      //{
      //   return _shoeCards[i];
      //} 
      #endregion


   }
}
