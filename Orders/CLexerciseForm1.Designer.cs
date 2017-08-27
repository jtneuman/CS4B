namespace Orders
{
    partial class CLexerciseForm1
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
            this.cboOrders = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dgvOrderRows = new System.Windows.Forms.DataGridView();
            this.btnAddOrderRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderRows)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOrders
            // 
            this.cboOrders.FormattingEnabled = true;
            this.cboOrders.Location = new System.Drawing.Point(13, 13);
            this.cboOrders.Name = "cboOrders";
            this.cboOrders.Size = new System.Drawing.Size(236, 21);
            this.cboOrders.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(255, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(13, 41);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(134, 23);
            this.btnRemoveOrder.TabIndex = 2;
            this.btnRemoveOrder.Text = "Remove Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(164, 41);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(119, 23);
            this.btnUpdateOrder.TabIndex = 3;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(300, 40);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(165, 23);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // dgvOrderRows
            // 
            this.dgvOrderRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderRows.Location = new System.Drawing.Point(13, 86);
            this.dgvOrderRows.Name = "dgvOrderRows";
            this.dgvOrderRows.Size = new System.Drawing.Size(452, 150);
            this.dgvOrderRows.TabIndex = 5;
            // 
            // btnAddOrderRow
            // 
            this.btnAddOrderRow.Location = new System.Drawing.Point(300, 257);
            this.btnAddOrderRow.Name = "btnAddOrderRow";
            this.btnAddOrderRow.Size = new System.Drawing.Size(165, 23);
            this.btnAddOrderRow.TabIndex = 6;
            this.btnAddOrderRow.Text = "Add Order Row";
            this.btnAddOrderRow.UseVisualStyleBackColor = true;
            // 
            // CLexerciseForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 341);
            this.Controls.Add(this.btnAddOrderRow);
            this.Controls.Add(this.dgvOrderRows);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboOrders);
            this.Name = "CLexerciseForm1";
            this.Text = "CLexerciseForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOrders;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dgvOrderRows;
        private System.Windows.Forms.Button btnAddOrderRow;
    }
}