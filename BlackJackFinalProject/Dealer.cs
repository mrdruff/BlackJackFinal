using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackFinalProject
{
   class Dealer:Person
   {
      // constructor
      public Dealer()
      {

      }

      public override string Hit(Card selectedCard)
      {
         this.AddCard(selectedCard);
         throw new NotImplementedException();
      }

      public override void Stand()
      {
         throw new NotImplementedException();
      }
   }
}
