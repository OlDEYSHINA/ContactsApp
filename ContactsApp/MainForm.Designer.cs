namespace ContactsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxContact = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userControl11 = new ContactsApp.UserControl1();
            this.buttonDeleteContact = new System.Windows.Forms.Button();
            this.buttonChangeParamInContact = new System.Windows.Forms.Button();
            this.buttonCreateNewContact = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxContact
            // 
            this.listBoxContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxContact.FormattingEnabled = true;
            this.listBoxContact.ItemHeight = 16;
            this.listBoxContact.Location = new System.Drawing.Point(12, 74);
            this.listBoxContact.Name = "listBoxContact";
            this.listBoxContact.Size = new System.Drawing.Size(275, 516);
            this.listBoxContact.TabIndex = 0;
            this.listBoxContact.SelectedIndexChanged += new System.EventHandler(this.listBoxContact_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.editToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 6;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.Contact = null;
            this.userControl11.Location = new System.Drawing.Point(293, 74);
            this.userControl11.MinimumSize = new System.Drawing.Size(473, 295);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(473, 316);
            this.userControl11.TabIndex = 28;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // buttonDeleteContact
            // 
            this.buttonDeleteContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteContact.Image = global::ContactsApp.Properties.Resources.DeleteContact;
            this.buttonDeleteContact.Location = new System.Drawing.Point(141, 595);
            this.buttonDeleteContact.Name = "buttonDeleteContact";
            this.buttonDeleteContact.Size = new System.Drawing.Size(60, 50);
            this.buttonDeleteContact.TabIndex = 27;
            this.buttonDeleteContact.UseVisualStyleBackColor = true;
            this.buttonDeleteContact.Click += new System.EventHandler(this.buttonDeleteContact_Click);
            // 
            // buttonChangeParamInContact
            // 
            this.buttonChangeParamInContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeParamInContact.CausesValidation = false;
            this.buttonChangeParamInContact.Image = global::ContactsApp.Properties.Resources.EditContact;
            this.buttonChangeParamInContact.Location = new System.Drawing.Point(78, 595);
            this.buttonChangeParamInContact.Name = "buttonChangeParamInContact";
            this.buttonChangeParamInContact.Size = new System.Drawing.Size(57, 50);
            this.buttonChangeParamInContact.TabIndex = 26;
            this.buttonChangeParamInContact.UseVisualStyleBackColor = true;
            this.buttonChangeParamInContact.Click += new System.EventHandler(this.buttonChangeParamInContact_Click);
            // 
            // buttonCreateNewContact
            // 
            this.buttonCreateNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateNewContact.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateNewContact.Image")));
            this.buttonCreateNewContact.Location = new System.Drawing.Point(12, 595);
            this.buttonCreateNewContact.Name = "buttonCreateNewContact";
            this.buttonCreateNewContact.Size = new System.Drawing.Size(60, 50);
            this.buttonCreateNewContact.TabIndex = 5;
            this.buttonCreateNewContact.UseVisualStyleBackColor = true;
            this.buttonCreateNewContact.Click += new System.EventHandler(this.buttonСreateNewContact_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 648);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonDeleteContact);
            this.Controls.Add(this.buttonChangeParamInContact);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCreateNewContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxContact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreateNewContact;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonChangeParamInContact;
        private System.Windows.Forms.Button buttonDeleteContact;
        public System.Windows.Forms.ListBox listBoxContact;
        private UserControl1 userControl11;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
    }
}

