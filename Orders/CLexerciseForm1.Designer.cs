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
            this.components = new System.ComponentModel.Container();
            this.cboOrders = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dgvOrderRows = new System.Windows.Forms.DataGridView();
            this.btnAddOrderRow = new System.Windows.Forms.Button();
            this.orderRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderRowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOrders
            // 
            this.cboOrders.DataSource = this.orderRowBindingSource;
            this.cboOrders.DisplayMember = "OrderId";
            this.cboOrders.FormattingEnabled = true;
            this.cboOrders.Location = new System.Drawing.Point(13, 13);
            this.cboOrders.Name = "cboOrders";
            this.cboOrders.Size = new System.Drawing.Size(236, 21);
            this.cboOrders.TabIndex = 0;
            this.cboOrders.ValueMember = "Product";
            this.cboOrders.SelectedIndexChanged += new System.EventHandler(this.cboOrders_SelectedIndexChanged);
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
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(164, 41);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(119, 23);
            this.btnUpdateOrder.TabIndex = 3;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(300, 40);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(165, 23);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dgvOrderRows
            // 
            this.dgvOrderRows.AutoGenerateColumns = false;
            this.dgvOrderRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderRowIdDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvOrderRows.DataSource = this.orderRowBindingSource;
            this.dgvOrderRows.Location = new System.Drawing.Point(13, 86);
            this.dgvOrderRows.Name = "dgvOrderRows";
            this.dgvOrderRows.Size = new System.Drawing.Size(452, 150);
            this.dgvOrderRows.TabIndex = 5;
            this.dgvOrderRows.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvOrderRows_UserDeletingRow);
            // 
            // btnAddOrderRow
            // 
            this.btnAddOrderRow.Location = new System.Drawing.Point(300, 257);
            this.btnAddOrderRow.Name = "btnAddOrderRow";
            this.btnAddOrderRow.Size = new System.Drawing.Size(165, 23);
            this.btnAddOrderRow.TabIndex = 6;
            this.btnAddOrderRow.Text = "Add Order Row";
            this.btnAddOrderRow.UseVisualStyleBackColor = true;
            this.btnAddOrderRow.Click += new System.EventHandler(this.btnAddOrderRow_Click);
            // 
            // orderRowBindingSource
            // 
            this.orderRowBindingSource.DataSource = typeof(DataLayer.OrderRow);
            // 
            // orderRowIdDataGridViewTextBoxColumn
            // 
            this.orderRowIdDataGridViewTextBoxColumn.DataPropertyName = "OrderRowId";
            this.orderRowIdDataGridViewTextBoxColumn.HeaderText = "OrderRowId";
            this.orderRowIdDataGridViewTextBoxColumn.Name = "orderRowIdDataGridViewTextBoxColumn";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // CLexerciseForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.btnAddOrderRow);
            this.Controls.Add(this.dgvOrderRows);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboOrders);
            this.Name = "CLexerciseForm1";
            this.Text = "CLexerciseForm1";
            this.Load += new System.EventHandler(this.CLexerciseForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRowBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderRowBindingSource;
    }
}