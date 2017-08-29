namespace Exercises
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
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.rbnEmployeeClass = new System.Windows.Forms.RadioButton();
            this.rbnIPersonInterface = new System.Windows.Forms.RadioButton();
            this.rbnIEmployeeInterface = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 177);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(259, 73);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // rbnEmployeeClass
            // 
            this.rbnEmployeeClass.AutoSize = true;
            this.rbnEmployeeClass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEmployeeClass.Location = new System.Drawing.Point(13, 37);
            this.rbnEmployeeClass.Name = "rbnEmployeeClass";
            this.rbnEmployeeClass.Size = new System.Drawing.Size(144, 24);
            this.rbnEmployeeClass.TabIndex = 1;
            this.rbnEmployeeClass.TabStop = true;
            this.rbnEmployeeClass.Text = "Employee Class";
            this.rbnEmployeeClass.UseVisualStyleBackColor = true;
            this.rbnEmployeeClass.CheckedChanged += new System.EventHandler(this.rbnEmployeeClass_CheckedChanged);
            this.rbnEmployeeClass.Click += new System.EventHandler(this.rbnEmployeeClass_Click);
            // 
            // rbnIPersonInterface
            // 
            this.rbnIPersonInterface.AutoSize = true;
            this.rbnIPersonInterface.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnIPersonInterface.Location = new System.Drawing.Point(13, 78);
            this.rbnIPersonInterface.Name = "rbnIPersonInterface";
            this.rbnIPersonInterface.Size = new System.Drawing.Size(140, 22);
            this.rbnIPersonInterface.TabIndex = 2;
            this.rbnIPersonInterface.TabStop = true;
            this.rbnIPersonInterface.Text = "IPerson Interface";
            this.rbnIPersonInterface.UseVisualStyleBackColor = true;
            this.rbnIPersonInterface.Click += new System.EventHandler(this.rbnIPersonInterface_Click);
            // 
            // rbnIEmployeeInterface
            // 
            this.rbnIEmployeeInterface.AutoSize = true;
            this.rbnIEmployeeInterface.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnIEmployeeInterface.Location = new System.Drawing.Point(13, 122);
            this.rbnIEmployeeInterface.Name = "rbnIEmployeeInterface";
            this.rbnIEmployeeInterface.Size = new System.Drawing.Size(178, 24);
            this.rbnIEmployeeInterface.TabIndex = 3;
            this.rbnIEmployeeInterface.TabStop = true;
            this.rbnIEmployeeInterface.Text = "IEmployee Interface";
            this.rbnIEmployeeInterface.UseVisualStyleBackColor = true;
            this.rbnIEmployeeInterface.Click += new System.EventHandler(this.rbnIEmployeeInterface_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rbnIEmployeeInterface);
            this.Controls.Add(this.rbnIPersonInterface);
            this.Controls.Add(this.rbnEmployeeClass);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.RadioButton rbnEmployeeClass;
        private System.Windows.Forms.RadioButton rbnIPersonInterface;
        private System.Windows.Forms.RadioButton rbnIEmployeeInterface;
    }
}

