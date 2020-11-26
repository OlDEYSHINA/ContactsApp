namespace ContactsApp
{
    partial class EditContactForm
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
            this.userControl11 = new ContactsApp.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Contact = null;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(468, 306);
            this.userControl11.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(185, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl11);
            this.Name = "EditContactForm";
            this.Text = "EditContactForm";
            this.Load += new System.EventHandler(this.EditContactForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button button1;
    }
}