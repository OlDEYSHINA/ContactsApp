using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsAppBLL;


namespace ContactsApp
{
    public partial class AddContactForm : Form
    {
        /// <summary>
        /// индикатор корректного выхода
        /// </summary>
        private bool _correctExit;

        /// <summary>
        /// обьявление класса для передачи данных в другую форму
        /// </summary>
        private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
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

        public AddContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// обнуление строк ошибок и коректного закрытия окна
        /// </summary>
        private void AddContactForm_Load(object sender, EventArgs e)
        {
            labelErrorName.Text = null;
            labelErrorSurname.Text = null;
            labelErrorBirthday.Text = null;
            labelErrorEMail.Text = null;
            labelErrorPhone.Text = null;
            labelErrorVK.Text = null;
            CorrectExit = false;
        }

        /// <summary>
        /// Подтверждение введенных данных
        /// Закроет окно и передаст информацию в случае отсутствия ошибок в введенных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {
            Person.CountError = 0;
            CorrectExit = true;
            Person.Surname = textBoxSurname.Text;
            labelErrorSurname.Text = Person.Label;
            Person.Name = textBoxName.Text;
            labelErrorName.Text = Person.Label;
            Person.Phone = textBoxPhone.Text;
            labelErrorPhone.Text = Person.Label;
            Person.EMail = textBoxEMail.Text;
            labelErrorEMail.Text = Person.Label;
            Person.VkPage = textBoxVK.Text;
            labelErrorVK.Text = Person.Label;
            Person.BirthDay = dateTimeBirthDay.Value;
            if (Person.CountError==0)
            {
                this.Close();
            }
        }
    }
    
}
