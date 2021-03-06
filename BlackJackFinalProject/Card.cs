﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackFinalProject
{
   class Card
   {
      // fields for Card class
      private string _face; // path location of the pic file for face
      private string _back;
      private int _cardValue;

      // Constructor
      public Card(string fLoc, string bLoc, int i)
      {
         _face = fLoc;
         _back = bLoc;
         _cardValue = i;
      }

      #region Properties
      // Properties
      public string Face
      {
         get
         {
            return _face;
         }
      }

      public string Suit
      {
         get
         {
            return _back;
         }
      } 

      public int CardValue
      {
         get { return _cardValue; }
      }
      #endregion
   }
}
