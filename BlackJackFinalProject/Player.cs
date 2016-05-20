using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackFinalProject
{
   class Player:Person
   {
      // fields
      private int _bank;
      

      // constructor
      public Player()
      {
         _bank = 500;
      }

      public override string Hit(Card selectedCard)
      {
         return "";
//         throw new NotImplementedException();
      }

      public override void Stand()
      {
//         throw new NotImplementedException();
      }

      public int Bank
      {
         get { return _bank; }
      }

      public void Bet(int betAmount)
      {
         _bank -= betAmount;
      }
   }
}
