namespace GenericCollections
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
            this.cboCars = new System.Windows.Forms.ComboBox();
            this.btnCollections = new System.Windows.Forms.Button();
            this.btnCollectionWithInterface = new System.Windows.Forms.Button();
            this.btnGenericCollection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCars
            // 
            this.cboCars.FormattingEnabled = true;
            this.cboCars.Location = new System.Drawing.Point(24, 23);
            this.cboCars.Name = "cboCars";
            this.cboCars.Size = new System.Drawing.Size(233, 21);
            this.cboCars.TabIndex = 0;
            // 
            // btnCollections
            // 
            this.btnCollections.Location = new System.Drawing.Point(24, 74);
            this.btnCollections.Name = "btnCollections";
            this.btnCollections.Size = new System.Drawing.Size(75, 23);
            this.btnCollections.TabIndex = 1;
            this.btnCollections.Text = "Collections";
            this.btnCollections.UseVisualStyleBackColor = true;
            this.btnCollections.Click += new System.EventHandler(this.btnCollections_Click);
            // 
            // btnCollectionWithInterface
            // 
            this.btnCollectionWithInterface.Location = new System.Drawing.Point(115, 74);
            this.btnCollectionWithInterface.Name = "btnCollectionWithInterface";
            this.btnCollectionWithInterface.Size = new System.Drawing.Size(142, 23);
            this.btnCollectionWithInterface.TabIndex = 2;
            this.btnCollectionWithInterface.Text = "Col Using Interfaces";
            this.btnCollectionWithInterface.UseVisualStyleBackColor = true;
            this.btnCollectionWithInterface.Click += new System.EventHandler(this.btnCollectionWithInterface_Click);
            // 
            // btnGenericCollection
            // 
            this.btnGenericCollection.Location = new System.Drawing.Point(24, 122);
            this.btnGenericCollection.Name = "btnGenericCollection";
            this.btnGenericCollection.Size = new System.Drawing.Size(75, 23);
            this.btnGenericCollection.TabIndex = 3;
            this.btnGenericCollection.Text = "Generics";
            this.btnGenericCollection.UseVisualStyleBackColor = true;
            this.btnGenericCollection.Click += new System.EventHandler(this.btnGenericCollection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGenericCollection);
            this.Controls.Add(this.btnCollectionWithInterface);
            this.Controls.Add(this.btnCollections);
            this.Controls.Add(this.cboCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCars;
        private System.Windows.Forms.Button btnCollections;
        private System.Windows.Forms.Button btnCollectionWithInterface;
        private System.Windows.Forms.Button btnGenericCollection;
    }
}

