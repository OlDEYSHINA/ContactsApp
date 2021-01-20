using ContactsAppBLL;
using System;
using System.Windows.Forms;


namespace ContactsApp
{
    public partial class AddEditContactForm : Form
    {
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

        public AddEditContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Подтверждение введенных данных
        /// Закроет окно и передаст информацию в случае отсутствия ошибок в введенных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {

            if (contactAddControl.CheckCorrectnessData())
            {
                this.Close();
                Contact = contactAddControl.Contact;
                CorrectExit = true;
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            contactAddControl.Contact = new Contact();
            contactAddControl.Contact = Contact;
            if (!string.IsNullOrEmpty(Contact.Surname))
            {
                contactAddControl.FillContact();
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }

}
