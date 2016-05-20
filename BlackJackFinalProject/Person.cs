using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackFinalProject
{
   abstract class Person
   {
      private List<Card> _myHand = new List<Card>();

      abstract public string Hit(Card selectedCard);

      abstract public void Stand();

      public List<Card> Hand
      {
         get { return _myHand; }
      }

      public void AddCard(Card selectedCard)
      {
         _myHand.Insert(0, selectedCard);
      }
   }
}
