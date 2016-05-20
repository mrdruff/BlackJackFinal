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
      
      Player me = new Player();
      Dealer myDealer = new Dealer();
      Shoe myShoe = new Shoe();
      int betTotal = 0;
      int shoeCounter = 0;
      List<PictureBox> playerBoxes = new List<PictureBox>();
      int playerPictureBoxCounter = 0;
      
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

         Update();
         DealCards();

         playerBoxes.Add(picP1);
         playerBoxes.Add(picP2);
         playerBoxes.Add(picP3);
         playerBoxes.Add(picP4);
         playerBoxes.Add(picP5);
         playerBoxes.Add(picP6);
         playerBoxes.Add(picP7);
         playerBoxes.Add(picP8);
         playerBoxes.Add(picP9);
         playerBoxes.Add(picP10);
         playerBoxes.Add(picP11);
      }


      public void Update()
      {
         lblBankAmount.Text = me.Bank.ToString();
         lblBetAmount.Text = betTotal.ToString();
      }

      public void DealCards()
      {
         myDealer.Hit(myShoe.ShoeCards[shoeCounter]);
         picD1.Image = lstCardPics.Images[myShoe.ShoeCards[shoeCounter].CardValue];
         shoeCounter++;
         myDealer.Hit(myShoe.ShoeCards[shoeCounter]);
         picD2.Image = lstCardPics.Images[myShoe.ShoeCards[shoeCounter].CardValue];
         shoeCounter++;

      }

      private void btnFive_Click(object sender, EventArgs e)
      {
         me.Bet(5);
         betTotal += 5;
         Update();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void btnHit_Click(object sender, EventArgs e)
      {
         me.Hit(myShoe.ShoeCards[shoeCounter]);
         playerBoxes[playerPictureBoxCounter].Image = lstCardPics.Images[myShoe.ShoeCards[shoeCounter].CardValue];
         shoeCounter++;
         playerPictureBoxCounter++;
      }

   }
}
