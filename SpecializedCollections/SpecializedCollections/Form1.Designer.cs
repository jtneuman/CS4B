namespace SpecializedCollections
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.grpItemSetting = new System.Windows.Forms.GroupBox();
            this.rbnAll = new System.Windows.Forms.RadioButton();
            this.rbnRegistered = new System.Windows.Forms.RadioButton();
            this.rbnUnregistered = new System.Windows.Forms.RadioButton();
            this.btnInterfaceConstraint = new System.Windows.Forms.Button();
            this.grpItemSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(23, 23);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(485, 121);
            this.lstItems.TabIndex = 0;
            // 
            // grpItemSetting
            // 
            this.grpItemSetting.Controls.Add(this.rbnUnregistered);
            this.grpItemSetting.Controls.Add(this.rbnRegistered);
            this.grpItemSetting.Controls.Add(this.rbnAll);
            this.grpItemSetting.Location = new System.Drawing.Point(23, 167);
            this.grpItemSetting.Name = "grpItemSetting";
            this.grpItemSetting.Size = new System.Drawing.Size(485, 61);
            this.grpItemSetting.TabIndex = 1;
            this.grpItemSetting.TabStop = false;
            this.grpItemSetting.Text = "Item Setting";
            // 
            // rbnAll
            // 
            this.rbnAll.AutoSize = true;
            this.rbnAll.Checked = true;
            this.rbnAll.Location = new System.Drawing.Point(7, 29);
            this.rbnAll.Name = "rbnAll";
            this.rbnAll.Size = new System.Drawing.Size(36, 17);
            this.rbnAll.TabIndex = 0;
            this.rbnAll.TabStop = true;
            this.rbnAll.Text = "All";
            this.rbnAll.UseVisualStyleBackColor = true;
            // 
            // rbnRegistered
            // 
            this.rbnRegistered.AutoSize = true;
            this.rbnRegistered.Location = new System.Drawing.Point(83, 29);
            this.rbnRegistered.Name = "rbnRegistered";
            this.rbnRegistered.Size = new System.Drawing.Size(76, 17);
            this.rbnRegistered.TabIndex = 1;
            this.rbnRegistered.Text = "Registered";
            this.rbnRegistered.UseVisualStyleBackColor = true;
            // 
            // rbnUnregistered
            // 
            this.rbnUnregistered.AutoSize = true;
            this.rbnUnregistered.Location = new System.Drawing.Point(233, 29);
            this.rbnUnregistered.Name = "rbnUnregistered";
            this.rbnUnregistered.Size = new System.Drawing.Size(85, 17);
            this.rbnUnregistered.TabIndex = 2;
            this.rbnUnregistered.Text = "Unregistered";
            this.rbnUnregistered.UseVisualStyleBackColor = true;
            // 
            // btnInterfaceConstraint
            // 
            this.btnInterfaceConstraint.Location = new System.Drawing.Point(23, 253);
            this.btnInterfaceConstraint.Name = "btnInterfaceConstraint";
            this.btnInterfaceConstraint.Size = new System.Drawing.Size(485, 38);
            this.btnInterfaceConstraint.TabIndex = 2;
            this.btnInterfaceConstraint.Text = "Interface Constraint";
            this.btnInterfaceConstraint.UseVisualStyleBackColor = true;
            this.btnInterfaceConstraint.Click += new System.EventHandler(this.btnInterfaceConstraint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 303);
            this.Controls.Add(this.btnInterfaceConstraint);
            this.Controls.Add(this.grpItemSetting);
            this.Controls.Add(this.lstItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpItemSetting.ResumeLayout(false);
            this.grpItemSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.GroupBox grpItemSetting;
        private System.Windows.Forms.RadioButton rbnUnregistered;
        private System.Windows.Forms.RadioButton rbnRegistered;
        private System.Windows.Forms.RadioButton rbnAll;
        private System.Windows.Forms.Button btnInterfaceConstraint;
    }
}

