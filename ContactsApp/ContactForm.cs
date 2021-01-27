using ContactsAppBLL;
using System;
using System.Windows.Forms;


namespace ContactsApp
{
    public partial class ContactForm : Form
    {
       
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
        
        public ContactForm()
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
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            contactAddControl.Contact = new Contact();
            contactAddControl.Contact = Contact;
        }

    }

}
