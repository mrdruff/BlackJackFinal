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
         this.lblIntructBet = new System.Windows.Forms.Label();
         this.lblBetAmount = new System.Windows.Forms.Label();
         this.lblBankInstruct = new System.Windows.Forms.Label();
         this.btnHit = new System.Windows.Forms.Button();
         this.btnStand = new System.Windows.Forms.Button();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnFive = new System.Windows.Forms.Button();
         this.btnTen = new System.Windows.Forms.Button();
         this.btnTwentyFive = new System.Windows.Forms.Button();
         this.btnHundred = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.lblBankAmount = new System.Windows.Forms.Label();
         this.lblOutput = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lstTestingCards
         // 
         this.lstTestingCards.FormattingEnabled = true;
         this.lstTestingCards.Location = new System.Drawing.Point(571, 40);
         this.lstTestingCards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.lstTestingCards.Name = "lstTestingCards";
         this.lstTestingCards.Size = new System.Drawing.Size(176, 251);
         this.lstTestingCards.TabIndex = 0;
         // 
         // lblIntructBet
         // 
         this.lblIntructBet.AutoSize = true;
         this.lblIntructBet.Location = new System.Drawing.Point(180, 82);
         this.lblIntructBet.Name = "lblIntructBet";
         this.lblIntructBet.Size = new System.Drawing.Size(43, 13);
         this.lblIntructBet.TabIndex = 1;
         this.lblIntructBet.Text = "Betting:";
         // 
         // lblBetAmount
         // 
         this.lblBetAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblBetAmount.Location = new System.Drawing.Point(261, 81);
         this.lblBetAmount.Name = "lblBetAmount";
         this.lblBetAmount.Size = new System.Drawing.Size(100, 23);
         this.lblBetAmount.TabIndex = 2;
         // 
         // lblBankInstruct
         // 
         this.lblBankInstruct.AutoSize = true;
         this.lblBankInstruct.Location = new System.Drawing.Point(180, 32);
         this.lblBankInstruct.Name = "lblBankInstruct";
         this.lblBankInstruct.Size = new System.Drawing.Size(35, 13);
         this.lblBankInstruct.TabIndex = 3;
         this.lblBankInstruct.Text = "Bank:";
         // 
         // btnHit
         // 
         this.btnHit.Location = new System.Drawing.Point(165, 207);
         this.btnHit.Name = "btnHit";
         this.btnHit.Size = new System.Drawing.Size(75, 23);
         this.btnHit.TabIndex = 4;
         this.btnHit.Text = "Hit";
         this.btnHit.UseVisualStyleBackColor = true;
         // 
         // btnStand
         // 
         this.btnStand.Location = new System.Drawing.Point(373, 207);
         this.btnStand.Name = "btnStand";
         this.btnStand.Size = new System.Drawing.Size(75, 23);
         this.btnStand.TabIndex = 5;
         this.btnStand.Text = "Stand";
         this.btnStand.UseVisualStyleBackColor = true;
         // 
         // btnClear
         // 
         this.btnClear.Location = new System.Drawing.Point(270, 207);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(75, 23);
         this.btnClear.TabIndex = 6;
         this.btnClear.Text = "Clear";
         this.btnClear.UseVisualStyleBackColor = true;
         // 
         // btnFive
         // 
         this.btnFive.Location = new System.Drawing.Point(108, 247);
         this.btnFive.Name = "btnFive";
         this.btnFive.Size = new System.Drawing.Size(75, 23);
         this.btnFive.TabIndex = 7;
         this.btnFive.Text = "$5";
         this.btnFive.UseVisualStyleBackColor = true;
         // 
         // btnTen
         // 
         this.btnTen.Location = new System.Drawing.Point(219, 247);
         this.btnTen.Name = "btnTen";
         this.btnTen.Size = new System.Drawing.Size(75, 23);
         this.btnTen.TabIndex = 8;
         this.btnTen.Text = "$10";
         this.btnTen.UseVisualStyleBackColor = true;
         // 
         // btnTwentyFive
         // 
         this.btnTwentyFive.Location = new System.Drawing.Point(319, 247);
         this.btnTwentyFive.Name = "btnTwentyFive";
         this.btnTwentyFive.Size = new System.Drawing.Size(75, 23);
         this.btnTwentyFive.TabIndex = 9;
         this.btnTwentyFive.Text = "$25";
         this.btnTwentyFive.UseVisualStyleBackColor = true;
         // 
         // btnHundred
         // 
         this.btnHundred.Location = new System.Drawing.Point(418, 247);
         this.btnHundred.Name = "btnHundred";
         this.btnHundred.Size = new System.Drawing.Size(75, 23);
         this.btnHundred.TabIndex = 10;
         this.btnHundred.Text = "$100";
         this.btnHundred.UseVisualStyleBackColor = true;
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(270, 293);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 23);
         this.btnClose.TabIndex = 11;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         // 
         // lblBankAmount
         // 
         this.lblBankAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblBankAmount.Location = new System.Drawing.Point(261, 22);
         this.lblBankAmount.Name = "lblBankAmount";
         this.lblBankAmount.Size = new System.Drawing.Size(100, 23);
         this.lblBankAmount.TabIndex = 12;
         // 
         // lblOutput
         // 
         this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblOutput.Location = new System.Drawing.Point(261, 142);
         this.lblOutput.Name = "lblOutput";
         this.lblOutput.Size = new System.Drawing.Size(100, 23);
         this.lblOutput.TabIndex = 13;
         // 
         // BlackJack
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(787, 328);
         this.Controls.Add(this.lblOutput);
         this.Controls.Add(this.lblBankAmount);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnHundred);
         this.Controls.Add(this.btnTwentyFive);
         this.Controls.Add(this.btnTen);
         this.Controls.Add(this.btnFive);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.btnStand);
         this.Controls.Add(this.btnHit);
         this.Controls.Add(this.lblBankInstruct);
         this.Controls.Add(this.lblBetAmount);
         this.Controls.Add(this.lblIntructBet);
         this.Controls.Add(this.lstTestingCards);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "BlackJack";
         this.Text = "Black Jack";
         this.Load += new System.EventHandler(this.BlackJack_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox lstTestingCards;
      private System.Windows.Forms.Label lblIntructBet;
      private System.Windows.Forms.Label lblBetAmount;
      private System.Windows.Forms.Label lblBankInstruct;
      private System.Windows.Forms.Button btnHit;
      private System.Windows.Forms.Button btnStand;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnFive;
      private System.Windows.Forms.Button btnTen;
      private System.Windows.Forms.Button btnTwentyFive;
      private System.Windows.Forms.Button btnHundred;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Label lblBankAmount;
      private System.Windows.Forms.Label lblOutput;
   }
}

