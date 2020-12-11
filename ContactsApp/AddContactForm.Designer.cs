namespace ContactsApp
{
    partial class AddContactForm
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
            this.ConfirmAdd = new System.Windows.Forms.Button();
            this.userControl11 = new ContactsApp.UserControl1();
            this.SuspendLayout();
            // 
            // ConfirmAdd
            // 
            this.ConfirmAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmAdd.Location = new System.Drawing.Point(195, 337);
            this.ConfirmAdd.MinimumSize = new System.Drawing.Size(139, 31);
            this.ConfirmAdd.Name = "ConfirmAdd";
            this.ConfirmAdd.Size = new System.Drawing.Size(139, 31);
            this.ConfirmAdd.TabIndex = 1;
            this.ConfirmAdd.Text = "Подтвердить";
            this.ConfirmAdd.UseVisualStyleBackColor = true;
            this.ConfirmAdd.Click += new System.EventHandler(this.buttonConfirmAdd_Click);
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.Contact = null;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(459, 319);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 385);
            this.Controls.Add(this.ConfirmAdd);
            this.Controls.Add(this.userControl11);
            this.Name = "AddContactForm";
            this.Text = "Addition Contact";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button ConfirmAdd;
    }
}