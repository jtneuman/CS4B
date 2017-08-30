namespace Exercises.Chapter11.EventExample
{
    partial class EventExampleMain
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrderRow = new System.Windows.Forms.Button();
            this.dgvProductOrderRows = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrderRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(13, 13);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products";
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(16, 40);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(121, 21);
            this.cboProducts.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(163, 13);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // nudProductQuantity
            // 
            this.nudProductQuantity.Location = new System.Drawing.Point(166, 40);
            this.nudProductQuantity.Name = "nudProductQuantity";
            this.nudProductQuantity.Size = new System.Drawing.Size(43, 20);
            this.nudProductQuantity.TabIndex = 3;
            // 
            // btnAddOrderRow
            // 
            this.btnAddOrderRow.Location = new System.Drawing.Point(16, 80);
            this.btnAddOrderRow.Name = "btnAddOrderRow";
            this.btnAddOrderRow.Size = new System.Drawing.Size(193, 35);
            this.btnAddOrderRow.TabIndex = 4;
            this.btnAddOrderRow.Text = "Add Order Row";
            this.btnAddOrderRow.UseVisualStyleBackColor = true;
            this.btnAddOrderRow.Click += new System.EventHandler(this.btnAddOrderRow_Click);
            // 
            // dgvProductOrderRows
            // 
            this.dgvProductOrderRows.AutoGenerateColumns = false;
            this.dgvProductOrderRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOrderRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvProductOrderRows.DataSource = this.productBindingSource;
            this.dgvProductOrderRows.Location = new System.Drawing.Point(16, 136);
            this.dgvProductOrderRows.Name = "dgvProductOrderRows";
            this.dgvProductOrderRows.Size = new System.Drawing.Size(256, 114);
            this.dgvProductOrderRows.TabIndex = 5;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Exercises.Chapter11.EventExample.Product);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // EventExampleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dgvProductOrderRows);
            this.Controls.Add(this.btnAddOrderRow);
            this.Controls.Add(this.nudProductQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.lblProducts);
            this.Name = "EventExampleMain";
            this.Text = "EventExampleMain";
            this.Load += new System.EventHandler(this.EventExampleMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrderRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudProductQuantity;
        private System.Windows.Forms.Button btnAddOrderRow;
        private System.Windows.Forms.DataGridView dgvProductOrderRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}