namespace MapCoordinates
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
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnAddCoordinate = new System.Windows.Forms.Button();
            this.lstCoordinates = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(13, 13);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(45, 13);
            this.lblLatitude.TabIndex = 0;
            this.lblLatitude.Text = "Latitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(16, 30);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(100, 20);
            this.txtLatitude.TabIndex = 1;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(144, 12);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(54, 13);
            this.lblLongitude.TabIndex = 2;
            this.lblLongitude.Text = "Longitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(147, 30);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(100, 20);
            this.txtLongitude.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 67);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(19, 94);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 5;
            // 
            // btnAddCoordinate
            // 
            this.btnAddCoordinate.Location = new System.Drawing.Point(171, 90);
            this.btnAddCoordinate.Name = "btnAddCoordinate";
            this.btnAddCoordinate.Size = new System.Drawing.Size(75, 23);
            this.btnAddCoordinate.TabIndex = 6;
            this.btnAddCoordinate.Text = "Add";
            this.btnAddCoordinate.UseVisualStyleBackColor = true;
            this.btnAddCoordinate.Click += new System.EventHandler(this.btnAddCoordinate_Click);
            // 
            // lstCoordinates
            // 
            this.lstCoordinates.FormattingEnabled = true;
            this.lstCoordinates.Location = new System.Drawing.Point(19, 121);
            this.lstCoordinates.Name = "lstCoordinates";
            this.lstCoordinates.Size = new System.Drawing.Size(227, 95);
            this.lstCoordinates.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstCoordinates);
            this.Controls.Add(this.btnAddCoordinate);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnAddCoordinate;
        private System.Windows.Forms.ListBox lstCoordinates;
        private System.Windows.Forms.Button btnDelete;
    }
}

