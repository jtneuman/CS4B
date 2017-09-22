namespace Car_Rental
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
            this.lvwAvailableVehicles = new System.Windows.Forms.ListView();
            this.colRegNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKmTariff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDayTariff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMeter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRentVehicle = new System.Windows.Forms.TabPage();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.lblAvailableVehicles = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMeterSetting = new System.Windows.Forms.Label();
            this.lblBookedVehicles = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtMeterReturn = new System.Windows.Forms.TextBox();
            this.lvwBookedVehicles = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblBookings = new System.Windows.Forms.Label();
            this.lvwBookings = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbxAddCustomer = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSocialSecurityNumber = new System.Windows.Forms.TextBox();
            this.gbxAddCar = new System.Windows.Forms.GroupBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.lblRegNr = new System.Windows.Forms.Label();
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.txtMeter = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRentVehicle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbxAddCustomer.SuspendLayout();
            this.gbxAddCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwAvailableVehicles
            // 
            this.lvwAvailableVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRegNo,
            this.colType,
            this.colKmTariff,
            this.colDayTariff,
            this.colMeter});
            this.lvwAvailableVehicles.Location = new System.Drawing.Point(6, 30);
            this.lvwAvailableVehicles.Name = "lvwAvailableVehicles";
            this.lvwAvailableVehicles.Size = new System.Drawing.Size(445, 193);
            this.lvwAvailableVehicles.TabIndex = 0;
            this.lvwAvailableVehicles.UseCompatibleStateImageBehavior = false;
            // 
            // colRegNo
            // 
            this.colRegNo.Text = "Registration Number";
            // 
            // colType
            // 
            this.colType.Text = "Type";
            // 
            // colKmTariff
            // 
            this.colKmTariff.Text = "Km Tariff";
            // 
            // colDayTariff
            // 
            this.colDayTariff.Text = "Day Tariff";
            // 
            // colMeter
            // 
            this.colMeter.Text = "Meter";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRentVehicle);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 326);
            this.tabControl1.TabIndex = 1;
            // 
            // tabRentVehicle
            // 
            this.tabRentVehicle.Controls.Add(this.btnRent);
            this.tabRentVehicle.Controls.Add(this.lblCustomers);
            this.tabRentVehicle.Controls.Add(this.cboCustomers);
            this.tabRentVehicle.Controls.Add(this.lblAvailableVehicles);
            this.tabRentVehicle.Controls.Add(this.lvwAvailableVehicles);
            this.tabRentVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabRentVehicle.Name = "tabRentVehicle";
            this.tabRentVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentVehicle.Size = new System.Drawing.Size(659, 300);
            this.tabRentVehicle.TabIndex = 0;
            this.tabRentVehicle.Text = "Rent Vehicle";
            this.tabRentVehicle.UseVisualStyleBackColor = true;
            this.tabRentVehicle.Click += new System.EventHandler(this.tabRentVehicle_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(545, 75);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 4;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(458, 11);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(56, 13);
            this.lblCustomers.TabIndex = 3;
            this.lblCustomers.Text = "Customers";
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(458, 30);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(163, 21);
            this.cboCustomers.TabIndex = 2;
            // 
            // lblAvailableVehicles
            // 
            this.lblAvailableVehicles.AutoSize = true;
            this.lblAvailableVehicles.Location = new System.Drawing.Point(7, 11);
            this.lblAvailableVehicles.Name = "lblAvailableVehicles";
            this.lblAvailableVehicles.Size = new System.Drawing.Size(93, 13);
            this.lblAvailableVehicles.TabIndex = 1;
            this.lblAvailableVehicles.Text = "Available Vehicles";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMeterSetting);
            this.tabPage2.Controls.Add(this.lblBookedVehicles);
            this.tabPage2.Controls.Add(this.btnReturn);
            this.tabPage2.Controls.Add(this.txtMeterReturn);
            this.tabPage2.Controls.Add(this.lvwBookedVehicles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Return Vehicle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMeterSetting
            // 
            this.lblMeterSetting.AutoSize = true;
            this.lblMeterSetting.Location = new System.Drawing.Point(501, 14);
            this.lblMeterSetting.Name = "lblMeterSetting";
            this.lblMeterSetting.Size = new System.Drawing.Size(70, 13);
            this.lblMeterSetting.TabIndex = 4;
            this.lblMeterSetting.Text = "Meter Setting";
            // 
            // lblBookedVehicles
            // 
            this.lblBookedVehicles.AutoSize = true;
            this.lblBookedVehicles.Location = new System.Drawing.Point(7, 14);
            this.lblBookedVehicles.Name = "lblBookedVehicles";
            this.lblBookedVehicles.Size = new System.Drawing.Size(87, 13);
            this.lblBookedVehicles.TabIndex = 3;
            this.lblBookedVehicles.Text = "Booked Vehicles";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(558, 81);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // txtMeterReturn
            // 
            this.txtMeterReturn.Location = new System.Drawing.Point(501, 33);
            this.txtMeterReturn.Name = "txtMeterReturn";
            this.txtMeterReturn.Size = new System.Drawing.Size(133, 20);
            this.txtMeterReturn.TabIndex = 1;
            // 
            // lvwBookedVehicles
            // 
            this.lvwBookedVehicles.Location = new System.Drawing.Point(7, 33);
            this.lvwBookedVehicles.Name = "lvwBookedVehicles";
            this.lvwBookedVehicles.Size = new System.Drawing.Size(474, 217);
            this.lvwBookedVehicles.TabIndex = 0;
            this.lvwBookedVehicles.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblBookings);
            this.tabPage3.Controls.Add(this.lvwBookings);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(659, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bookings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Location = new System.Drawing.Point(15, 14);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(51, 13);
            this.lblBookings.TabIndex = 1;
            this.lblBookings.Text = "Bookings";
            // 
            // lvwBookings
            // 
            this.lvwBookings.Location = new System.Drawing.Point(15, 33);
            this.lvwBookings.Name = "lvwBookings";
            this.lvwBookings.Size = new System.Drawing.Size(631, 248);
            this.lvwBookings.TabIndex = 0;
            this.lvwBookings.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbxAddCustomer);
            this.tabPage4.Controls.Add(this.gbxAddCar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(659, 300);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Data";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbxAddCustomer
            // 
            this.gbxAddCustomer.Controls.Add(this.btnAddCustomer);
            this.gbxAddCustomer.Controls.Add(this.lblLastName);
            this.gbxAddCustomer.Controls.Add(this.lblFirstName);
            this.gbxAddCustomer.Controls.Add(this.lblSSN);
            this.gbxAddCustomer.Controls.Add(this.txtLastName);
            this.gbxAddCustomer.Controls.Add(this.txtFirstName);
            this.gbxAddCustomer.Controls.Add(this.txtSocialSecurityNumber);
            this.gbxAddCustomer.Location = new System.Drawing.Point(283, 39);
            this.gbxAddCustomer.Name = "gbxAddCustomer";
            this.gbxAddCustomer.Size = new System.Drawing.Size(347, 214);
            this.gbxAddCustomer.TabIndex = 1;
            this.gbxAddCustomer.TabStop = false;
            this.gbxAddCustomer.Text = "Add Customer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(248, 151);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(6, 23);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(117, 13);
            this.lblSSN.TabIndex = 3;
            this.lblSSN.Text = "Social Security Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 108);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(193, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(193, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtSocialSecurityNumber
            // 
            this.txtSocialSecurityNumber.Location = new System.Drawing.Point(131, 19);
            this.txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            this.txtSocialSecurityNumber.Size = new System.Drawing.Size(193, 20);
            this.txtSocialSecurityNumber.TabIndex = 0;
            // 
            // gbxAddCar
            // 
            this.gbxAddCar.Controls.Add(this.btnAddVehicle);
            this.gbxAddCar.Controls.Add(this.lblType);
            this.gbxAddCar.Controls.Add(this.lblMeter);
            this.gbxAddCar.Controls.Add(this.lblRegNr);
            this.gbxAddCar.Controls.Add(this.cboTypes);
            this.gbxAddCar.Controls.Add(this.txtMeter);
            this.gbxAddCar.Controls.Add(this.txtRegNo);
            this.gbxAddCar.Location = new System.Drawing.Point(16, 39);
            this.gbxAddCar.Name = "gbxAddCar";
            this.gbxAddCar.Size = new System.Drawing.Size(246, 214);
            this.gbxAddCar.TabIndex = 0;
            this.gbxAddCar.TabStop = false;
            this.gbxAddCar.Text = "Add Car";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(145, 151);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddVehicle.TabIndex = 6;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(21, 107);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // lblMeter
            // 
            this.lblMeter.AutoSize = true;
            this.lblMeter.Location = new System.Drawing.Point(18, 63);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(34, 13);
            this.lblMeter.TabIndex = 4;
            this.lblMeter.Text = "Meter";
            // 
            // lblRegNr
            // 
            this.lblRegNr.AutoSize = true;
            this.lblRegNr.Location = new System.Drawing.Point(18, 20);
            this.lblRegNr.Name = "lblRegNr";
            this.lblRegNr.Size = new System.Drawing.Size(47, 13);
            this.lblRegNr.TabIndex = 3;
            this.lblRegNr.Text = "Reg.No.";
            // 
            // cboTypes
            // 
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.Location = new System.Drawing.Point(68, 108);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(152, 21);
            this.cboTypes.TabIndex = 2;
            // 
            // txtMeter
            // 
            this.txtMeter.Location = new System.Drawing.Point(68, 63);
            this.txtMeter.Name = "txtMeter";
            this.txtMeter.Size = new System.Drawing.Size(152, 20);
            this.txtMeter.TabIndex = 1;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(68, 20);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(152, 20);
            this.txtRegNo.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(599, 354);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 401);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRentVehicle.ResumeLayout(false);
            this.tabRentVehicle.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gbxAddCustomer.ResumeLayout(false);
            this.gbxAddCustomer.PerformLayout();
            this.gbxAddCar.ResumeLayout(false);
            this.gbxAddCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwAvailableVehicles;
        private System.Windows.Forms.ColumnHeader colRegNo;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colKmTariff;
        private System.Windows.Forms.ColumnHeader colDayTariff;
        private System.Windows.Forms.ColumnHeader colMeter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRentVehicle;
        private System.Windows.Forms.Label lblAvailableVehicles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblMeterSetting;
        private System.Windows.Forms.Label lblBookedVehicles;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtMeterReturn;
        private System.Windows.Forms.ListView lvwBookedVehicles;
        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.ListView lvwBookings;
        private System.Windows.Forms.GroupBox gbxAddCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSocialSecurityNumber;
        private System.Windows.Forms.GroupBox gbxAddCar;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.Label lblRegNr;
        private System.Windows.Forms.ComboBox cboTypes;
        private System.Windows.Forms.TextBox txtMeter;
        private System.Windows.Forms.TextBox txtRegNo;
    }
}

