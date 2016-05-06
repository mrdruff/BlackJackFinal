using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackFinalProject
{
   public partial class BlackJack : Form
   {
      // we all are in
      public BlackJack()
      {
         InitializeComponent();
      }

      private void BlackJack_Load(object sender, EventArgs e)
      {
         #region Old Test Code
         //string[] suits = { "hearts", "clubs", "spades", "diamonds" };
         //string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10",
         //                    "Jack", "Queen", "King", "Ace" };
         //Card[] oneDeck = new Card[52];

         //int counter = 0;
         //for (int i = 0; i < 4; i++)
         //{
         //   for (int j = 0; j < 13; j++)
         //   {
         //      oneDeck[counter] = new Card(faces[j], suits[i]);
         //      lstTestingCards.Items.Add(oneDeck[counter].Face +
         //         " of " + oneDeck[counter].Suit);
         //      counter++;
         //   }
         //} 

         //for (int i = 0; i < 52; i++)
         //{
         //   oneDeck[i] = new Card("2", "hearts");
         //}
         #endregion

         #region TEST CODE - Display Cards in Listbox Control
         Shoe myShoe = new Shoe();
         for (int i = 0; i < 312; i++)
         {
            lstTestingCards.Items.Add(myShoe.ShoeCards[i].Face + " of " + myShoe.ShoeCards[i].Suit);
         }

         #region Alternative Display Shoe Cards Solution using a method in the Shoe class
         //Shoe myShoe = new Shoe();
         //for (int i = 0; i < 312; i++)
         //{
         //   lstTestingCards.Items.Add(myShoe.SelectedCard(i).Face + " of " + myShoe.SelectedCard(i).Suit);
         //} 
         #endregion 
         #endregion
      }
   }
}
