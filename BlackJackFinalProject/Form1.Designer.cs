namespace BlackJackFinalProject
{
   partial class BlackJack
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lstTestingCards = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // lstTestingCards
         // 
         this.lstTestingCards.FormattingEnabled = true;
         this.lstTestingCards.ItemHeight = 20;
         this.lstTestingCards.Location = new System.Drawing.Point(857, 61);
         this.lstTestingCards.Name = "lstTestingCards";
         this.lstTestingCards.Size = new System.Drawing.Size(262, 384);
         this.lstTestingCards.TabIndex = 0;
         // 
         // BlackJack
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1181, 505);
         this.Controls.Add(this.lstTestingCards);
         this.Name = "BlackJack";
         this.Text = "Black Jack";
         this.Load += new System.EventHandler(this.BlackJack_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListBox lstTestingCards;
   }
}

