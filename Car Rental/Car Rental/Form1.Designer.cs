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
            this.tabReturnVehicle = new System.Windows.Forms.TabPage();
            this.lblMeterSetting = new System.Windows.Forms.Label();
            this.lblBookedVehicles = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtMeterReturn = new System.Windows.Forms.TextBox();
            this.lvwBookedVehicles = new System.Windows.Forms.ListView();
            this.colRegNoReturnVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTypeReturnVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKmTariffReturnVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDayTariffReturnVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMeterReturnVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.lblBookings = new System.Windows.Forms.Label();
            this.lvwBookings = new System.Windows.Forms.ListView();
            this.colBookingIdBookingsTab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegNoBookingsTab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTypeBookingsTab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomerBookingsTab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentedBookingsTab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReturnedBookingsTab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAddData = new System.Windows.Forms.TabPage();
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRentVehicle.SuspendLayout();
            this.tabReturnVehicle.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.tabAddData.SuspendLayout();
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
            this.lvwAvailableVehicles.View = System.Windows.Forms.View.Details;
            // 
            // colRegNo
            // 
            this.colRegNo.Text = "Registration Number";
            this.colRegNo.Width = 120;
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
            this.tabControl1.Controls.Add(this.tabReturnVehicle);
            this.tabControl1.Controls.Add(this.tabBookings);
            this.tabControl1.Controls.Add(this.tabAddData);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 326);
            this.tabControl1.TabIndex = 1;
            // 
            // tabRentVehicle
            // 
            this.tabRentVehicle.Controls.Add(this.BtnSave);
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
            this.btnRent.Location = new System.Drawing.Point(461, 75);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(159, 33);
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
            // tabReturnVehicle
            // 
            this.tabReturnVehicle.Controls.Add(this.lblMeterSetting);
            this.tabReturnVehicle.Controls.Add(this.lblBookedVehicles);
            this.tabReturnVehicle.Controls.Add(this.btnReturn);
            this.tabReturnVehicle.Controls.Add(this.txtMeterReturn);
            this.tabReturnVehicle.Controls.Add(this.lvwBookedVehicles);
            this.tabReturnVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabReturnVehicle.Name = "tabReturnVehicle";
            this.tabReturnVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabReturnVehicle.Size = new System.Drawing.Size(659, 300);
            this.tabReturnVehicle.TabIndex = 1;
            this.tabReturnVehicle.Text = "Return Vehicle";
            this.tabReturnVehicle.UseVisualStyleBackColor = true;
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
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.lvwBookedVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRegNoReturnVehicle,
            this.colTypeReturnVehicle,
            this.colKmTariffReturnVehicle,
            this.colDayTariffReturnVehicle,
            this.colMeterReturnVehicle});
            this.lvwBookedVehicles.Location = new System.Drawing.Point(7, 33);
            this.lvwBookedVehicles.Name = "lvwBookedVehicles";
            this.lvwBookedVehicles.Size = new System.Drawing.Size(474, 217);
            this.lvwBookedVehicles.TabIndex = 0;
            this.lvwBookedVehicles.UseCompatibleStateImageBehavior = false;
            this.lvwBookedVehicles.View = System.Windows.Forms.View.Details;
            // 
            // colRegNoReturnVehicle
            // 
            this.colRegNoReturnVehicle.Text = "Registration Number";
            this.colRegNoReturnVehicle.Width = 120;
            // 
            // colTypeReturnVehicle
            // 
            this.colTypeReturnVehicle.Text = "Type";
            // 
            // colKmTariffReturnVehicle
            // 
            this.colKmTariffReturnVehicle.Text = "Km Tariff";
            // 
            // colDayTariffReturnVehicle
            // 
            this.colDayTariffReturnVehicle.Text = "Day Tariff";
            // 
            // colMeterReturnVehicle
            // 
            this.colMeterReturnVehicle.Text = "Meter";
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.lblBookings);
            this.tabBookings.Controls.Add(this.lvwBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 22);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Size = new System.Drawing.Size(659, 300);
            this.tabBookings.TabIndex = 2;
            this.tabBookings.Text = "Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
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
            this.lvwBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBookingIdBookingsTab,
            this.colRegNoBookingsTab,
            this.colTypeBookingsTab,
            this.colCustomerBookingsTab,
            this.colRentedBookingsTab,
            this.colReturnedBookingsTab});
            this.lvwBookings.Location = new System.Drawing.Point(15, 33);
            this.lvwBookings.Name = "lvwBookings";
            this.lvwBookings.Size = new System.Drawing.Size(631, 248);
            this.lvwBookings.TabIndex = 0;
            this.lvwBookings.UseCompatibleStateImageBehavior = false;
            this.lvwBookings.View = System.Windows.Forms.View.Details;
            // 
            // colBookingIdBookingsTab
            // 
            this.colBookingIdBookingsTab.Text = "Booking Id";
            this.colBookingIdBookingsTab.Width = 80;
            // 
            // colRegNoBookingsTab
            // 
            this.colRegNoBookingsTab.Text = "Reg. No.";
            this.colRegNoBookingsTab.Width = 80;
            // 
            // colTypeBookingsTab
            // 
            this.colTypeBookingsTab.Text = "Type";
            this.colTypeBookingsTab.Width = 80;
            // 
            // colCustomerBookingsTab
            // 
            this.colCustomerBookingsTab.Text = "Customer";
            this.colCustomerBookingsTab.Width = 150;
            // 
            // colRentedBookingsTab
            // 
            this.colRentedBookingsTab.Text = "Rented Date";
            this.colRentedBookingsTab.Width = 80;
            // 
            // colReturnedBookingsTab
            // 
            this.colReturnedBookingsTab.Text = "Returned Date";
            this.colReturnedBookingsTab.Width = 100;
            // 
            // tabAddData
            // 
            this.tabAddData.Controls.Add(this.gbxAddCustomer);
            this.tabAddData.Controls.Add(this.gbxAddCar);
            this.tabAddData.Location = new System.Drawing.Point(4, 22);
            this.tabAddData.Name = "tabAddData";
            this.tabAddData.Size = new System.Drawing.Size(659, 300);
            this.tabAddData.TabIndex = 3;
            this.tabAddData.Text = "Add Data";
            this.tabAddData.UseVisualStyleBackColor = true;
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
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
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
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(461, 124);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(158, 33);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.tabReturnVehicle.ResumeLayout(false);
            this.tabReturnVehicle.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            this.tabBookings.PerformLayout();
            this.tabAddData.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabReturnVehicle;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.TabPage tabAddData;
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
        private System.Windows.Forms.ColumnHeader colRegNoReturnVehicle;
        private System.Windows.Forms.ColumnHeader colTypeReturnVehicle;
        private System.Windows.Forms.ColumnHeader colKmTariffReturnVehicle;
        private System.Windows.Forms.ColumnHeader colDayTariffReturnVehicle;
        private System.Windows.Forms.ColumnHeader colMeterReturnVehicle;
        private System.Windows.Forms.ColumnHeader colBookingIdBookingsTab;
        private System.Windows.Forms.ColumnHeader colRegNoBookingsTab;
        private System.Windows.Forms.ColumnHeader colTypeBookingsTab;
        private System.Windows.Forms.ColumnHeader colCustomerBookingsTab;
        private System.Windows.Forms.ColumnHeader colRentedBookingsTab;
        private System.Windows.Forms.ColumnHeader colReturnedBookingsTab;
        private System.Windows.Forms.Button BtnSave;
    }
}

