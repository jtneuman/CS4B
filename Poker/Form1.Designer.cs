namespace Poker
{
    partial class Poker
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
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblDealerHand = new System.Windows.Forms.Label();
            this.panDealer = new System.Windows.Forms.Panel();
            this.lblWinner = new System.Windows.Forms.Label();
            this.panPlayer = new System.Windows.Forms.Panel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerHand = new System.Windows.Forms.Label();
            this.btnDeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(26, 26);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(105, 32);
            this.lblDealer.TabIndex = 0;
            this.lblDealer.Text = "Dealer";
            // 
            // lblDealerHand
            // 
            this.lblDealerHand.AutoSize = true;
            this.lblDealerHand.Location = new System.Drawing.Point(150, 26);
            this.lblDealerHand.Name = "lblDealerHand";
            this.lblDealerHand.Size = new System.Drawing.Size(90, 32);
            this.lblDealerHand.TabIndex = 1;
            this.lblDealerHand.Text = "Hand:";
            // 
            // panDealer
            // 
            this.panDealer.Location = new System.Drawing.Point(32, 81);
            this.panDealer.Name = "panDealer";
            this.panDealer.Size = new System.Drawing.Size(434, 100);
            this.panDealer.TabIndex = 2;
            // 
            // lblWinner
            // 
            this.lblWinner.Location = new System.Drawing.Point(32, 197);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(434, 107);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panPlayer
            // 
            this.panPlayer.Location = new System.Drawing.Point(38, 329);
            this.panPlayer.Name = "panPlayer";
            this.panPlayer.Size = new System.Drawing.Size(428, 100);
            this.panPlayer.TabIndex = 4;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(38, 457);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(105, 32);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player";
            // 
            // lblPlayerHand
            // 
            this.lblPlayerHand.AutoSize = true;
            this.lblPlayerHand.Location = new System.Drawing.Point(150, 457);
            this.lblPlayerHand.Name = "lblPlayerHand";
            this.lblPlayerHand.Size = new System.Drawing.Size(90, 32);
            this.lblPlayerHand.TabIndex = 6;
            this.lblPlayerHand.Text = "Hand:";
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(44, 510);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(422, 55);
            this.btnDeal.TabIndex = 7;
            this.btnDeal.Text = "DEAL NEW HAND";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // Poker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 587);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lblPlayerHand);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.panPlayer);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.panDealer);
            this.Controls.Add(this.lblDealerHand);
            this.Controls.Add(this.lblDealer);
            this.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Poker";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.Poker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblDealerHand;
        private System.Windows.Forms.Panel panDealer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Panel panPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayerHand;
        private System.Windows.Forms.Button btnDeal;
    }
}

