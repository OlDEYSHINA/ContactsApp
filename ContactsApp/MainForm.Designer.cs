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
            this.listBoxContact = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateNewContact = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxVK = new System.Windows.Forms.TextBox();
            this.dateTimeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.buttonChangeParamInContact = new System.Windows.Forms.Button();
            this.buttonDeleteContact = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxContact
            // 
            this.listBoxContact.FormattingEnabled = true;
            this.listBoxContact.ItemHeight = 16;
            this.listBoxContact.Location = new System.Drawing.Point(12, 74);
            this.listBoxContact.Name = "listBoxContact";
            this.listBoxContact.Size = new System.Drawing.Size(275, 532);
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
            this.menuStrip1.Size = new System.Drawing.Size(818, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
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
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
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
            // buttonCreateNewContact
            // 
            this.buttonCreateNewContact.Location = new System.Drawing.Point(12, 612);
            this.buttonCreateNewContact.Name = "buttonCreateNewContact";
            this.buttonCreateNewContact.Size = new System.Drawing.Size(91, 33);
            this.buttonCreateNewContact.TabIndex = 5;
            this.buttonCreateNewContact.Text = "Создать";
            this.buttonCreateNewContact.UseVisualStyleBackColor = true;
            this.buttonCreateNewContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "vk.com:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSurname.Location = new System.Drawing.Point(414, 108);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(368, 22);
            this.textBoxSurname.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxName.Location = new System.Drawing.Point(414, 148);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(368, 22);
            this.textBoxName.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPhone.Location = new System.Drawing.Point(414, 228);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(368, 22);
            this.textBoxPhone.TabIndex = 15;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEMail.Location = new System.Drawing.Point(414, 268);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.ReadOnly = true;
            this.textBoxEMail.Size = new System.Drawing.Size(368, 22);
            this.textBoxEMail.TabIndex = 16;
            // 
            // textBoxVK
            // 
            this.textBoxVK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxVK.Location = new System.Drawing.Point(414, 308);
            this.textBoxVK.Name = "textBoxVK";
            this.textBoxVK.ReadOnly = true;
            this.textBoxVK.Size = new System.Drawing.Size(368, 22);
            this.textBoxVK.TabIndex = 17;
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.Location = new System.Drawing.Point(414, 188);
            this.dateTimeBirthDay.Name = "dateTimeBirthDay";
            this.dateTimeBirthDay.Size = new System.Drawing.Size(212, 22);
            this.dateTimeBirthDay.TabIndex = 18;
            // 
            // buttonChangeParamInContact
            // 
            this.buttonChangeParamInContact.CausesValidation = false;
            this.buttonChangeParamInContact.Location = new System.Drawing.Point(104, 612);
            this.buttonChangeParamInContact.Name = "buttonChangeParamInContact";
            this.buttonChangeParamInContact.Size = new System.Drawing.Size(91, 33);
            this.buttonChangeParamInContact.TabIndex = 26;
            this.buttonChangeParamInContact.Text = "Изменить";
            this.buttonChangeParamInContact.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteContact
            // 
            this.buttonDeleteContact.Location = new System.Drawing.Point(196, 612);
            this.buttonDeleteContact.Name = "buttonDeleteContact";
            this.buttonDeleteContact.Size = new System.Drawing.Size(91, 33);
            this.buttonDeleteContact.TabIndex = 27;
            this.buttonDeleteContact.Text = "Удалить";
            this.buttonDeleteContact.UseVisualStyleBackColor = true;
            this.buttonDeleteContact.Click += new System.EventHandler(this.buttonDeleteContact_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 648);
            this.Controls.Add(this.buttonDeleteContact);
            this.Controls.Add(this.buttonChangeParamInContact);
            this.Controls.Add(this.dateTimeBirthDay);
            this.Controls.Add(this.textBoxVK);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCreateNewContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxContact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ContactsApp";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxVK;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDay;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonChangeParamInContact;
        private System.Windows.Forms.Button buttonDeleteContact;
        public System.Windows.Forms.ListBox listBoxContact;
    }
}

