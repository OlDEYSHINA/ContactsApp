namespace ContactsApp
{
    partial class AddEditContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditContactForm));
            this.ConfirmAdd = new System.Windows.Forms.Button();
            this.contactAddControl = new ContactsApp.ContactControl();
            this.SuspendLayout();
            // 
            // ConfirmAdd
            // 
            this.ConfirmAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmAdd.Location = new System.Drawing.Point(194, 276);
            this.ConfirmAdd.MinimumSize = new System.Drawing.Size(139, 31);
            this.ConfirmAdd.Name = "ConfirmAdd";
            this.ConfirmAdd.Size = new System.Drawing.Size(241, 31);
            this.ConfirmAdd.TabIndex = 1;
            this.ConfirmAdd.Text = "Подтвердить";
            this.ConfirmAdd.UseVisualStyleBackColor = true;
            this.ConfirmAdd.Click += new System.EventHandler(this.buttonConfirmAdd_Click);
            // 
            // contactAddControl
            // 
            this.contactAddControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactAddControl.Contact = null;
            this.contactAddControl.Location = new System.Drawing.Point(12, 12);
            this.contactAddControl.Name = "contactAddControl";
            this.contactAddControl.Size = new System.Drawing.Size(478, 207);
            this.contactAddControl.TabIndex = 0;
            this.contactAddControl.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // AddEditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 319);
            this.Controls.Add(this.ConfirmAdd);
            this.Controls.Add(this.contactAddControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(651, 366);
            this.Name = "AddEditContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ContactControl contactAddControl;
        private System.Windows.Forms.Button ConfirmAdd;
    }
}