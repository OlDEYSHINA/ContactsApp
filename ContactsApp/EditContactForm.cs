using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsAppBLL;

namespace ContactsApp
{
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// индикатор корректного выхода
        /// </summary>
        private bool _correctExit;

        /// <summary>
        /// обьявление класса для передачи данных в другую форму
        /// </summary>
        private Contact _contact;

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }
        public bool CorrectExit
        {
            get
            {
                return _correctExit;
            }
            private set
            {
                _correctExit = value;
            }
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            userControl11.Contact = new Contact();
            userControl11.PutInName(Contact.Name);
            userControl11.PutInSurname(Contact.Surname);
            userControl11.PutInBirthday(Contact.BirthDay);
            userControl11.PutInEMail(Contact.EMail);
            userControl11.PutInPhone(Contact.PhoneNumber.Number);
            userControl11.PutInVk(Contact.VkPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControl11.CheckCorrectnessData())
            {
                this.Close();
                Contact = userControl11.Contact;
                CorrectExit = true;
            }
        }
    }
}
