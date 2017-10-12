namespace StockHistory
{
    partial class Form1
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
            this.TxtResult = new System.Windows.Forms.RichTextBox();
            this.BtnGetStockData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(12, 12);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(399, 346);
            this.TxtResult.TabIndex = 0;
            this.TxtResult.Text = "";
            // 
            // BtnGetStockData
            // 
            this.BtnGetStockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetStockData.Location = new System.Drawing.Point(265, 364);
            this.BtnGetStockData.Name = "BtnGetStockData";
            this.BtnGetStockData.Size = new System.Drawing.Size(145, 39);
            this.BtnGetStockData.TabIndex = 1;
            this.BtnGetStockData.Text = "Get Stock Data";
            this.BtnGetStockData.UseVisualStyleBackColor = true;
            this.BtnGetStockData.Click += new System.EventHandler(this.BtnGetStockData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 417);
            this.Controls.Add(this.BtnGetStockData);
            this.Controls.Add(this.TxtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtResult;
        private System.Windows.Forms.Button BtnGetStockData;
    }
}

