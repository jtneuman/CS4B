namespace GuiForSearchExtensionMethod
{
    partial class SearchForm
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
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cboResult = new System.Windows.Forms.ComboBox();
            this.btnPrintToListBox = new System.Windows.Forms.Button();
            this.btnPrintToComboxBox = new System.Windows.Forms.Button();
            this.btnCallFunc = new System.Windows.Forms.Button();
            this.btnCallPredicate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(13, 13);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(218, 95);
            this.lstResult.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 133);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(60, 133);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(155, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(16, 194);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(60, 194);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(170, 23);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "\"No Result\"";
            // 
            // cboResult
            // 
            this.cboResult.FormattingEnabled = true;
            this.cboResult.Location = new System.Drawing.Point(19, 242);
            this.cboResult.Name = "cboResult";
            this.cboResult.Size = new System.Drawing.Size(212, 21);
            this.cboResult.TabIndex = 6;
            // 
            // btnPrintToListBox
            // 
            this.btnPrintToListBox.Location = new System.Drawing.Point(19, 281);
            this.btnPrintToListBox.Name = "btnPrintToListBox";
            this.btnPrintToListBox.Size = new System.Drawing.Size(212, 23);
            this.btnPrintToListBox.TabIndex = 7;
            this.btnPrintToListBox.Text = "PrintToListBox";
            this.btnPrintToListBox.UseVisualStyleBackColor = true;
            this.btnPrintToListBox.Click += new System.EventHandler(this.btnPrintToListBox_Click);
            // 
            // btnPrintToComboxBox
            // 
            this.btnPrintToComboxBox.Location = new System.Drawing.Point(19, 321);
            this.btnPrintToComboxBox.Name = "btnPrintToComboxBox";
            this.btnPrintToComboxBox.Size = new System.Drawing.Size(211, 23);
            this.btnPrintToComboxBox.TabIndex = 8;
            this.btnPrintToComboxBox.Text = "Print to Combo Box";
            this.btnPrintToComboxBox.UseVisualStyleBackColor = true;
            // 
            // btnCallFunc
            // 
            this.btnCallFunc.Location = new System.Drawing.Point(19, 362);
            this.btnCallFunc.Name = "btnCallFunc";
            this.btnCallFunc.Size = new System.Drawing.Size(100, 23);
            this.btnCallFunc.TabIndex = 9;
            this.btnCallFunc.Text = "Call Func";
            this.btnCallFunc.UseVisualStyleBackColor = true;
            // 
            // btnCallPredicate
            // 
            this.btnCallPredicate.Location = new System.Drawing.Point(125, 362);
            this.btnCallPredicate.Name = "btnCallPredicate";
            this.btnCallPredicate.Size = new System.Drawing.Size(104, 23);
            this.btnCallPredicate.TabIndex = 10;
            this.btnCallPredicate.Text = "Call Predicate";
            this.btnCallPredicate.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 475);
            this.Controls.Add(this.btnCallPredicate);
            this.Controls.Add(this.btnCallFunc);
            this.Controls.Add(this.btnPrintToComboxBox);
            this.Controls.Add(this.btnPrintToListBox);
            this.Controls.Add(this.cboResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lstResult);
            this.Name = "SearchForm";
            this.Text = "Search Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cboResult;
        private System.Windows.Forms.Button btnPrintToListBox;
        private System.Windows.Forms.Button btnPrintToComboxBox;
        private System.Windows.Forms.Button btnCallFunc;
        private System.Windows.Forms.Button btnCallPredicate;
    }
}

