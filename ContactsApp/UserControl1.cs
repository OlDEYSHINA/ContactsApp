using ContactsAppBLL;
using System;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class UserControl1 : UserControl
    {
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
        public UserControl1()
        {
            InitializeComponent();
        }

        public void FillContact()
        {
            textBoxSurname.Text = Contact.Surname;
            textBoxName.Text = Contact.Name;
            dateTimeBirthDay.Value = Contact.BirthDay;
            textBoxPhone.Text = Contact.PhoneNumber.Number;
            textBoxEMail.Text = Contact.EMail;
            textBoxVK.Text = Contact.VkPage;
        }
        public void PutInSurname(string value)
        {
            textBoxSurname.Text = value;
        }
        public void PutInName(string value)
        {
            textBoxName.Text = value;
        }

        public void PutInBirthday(DateTime value)
        {
            dateTimeBirthDay.Value = value;
        }
        public void PutInPhone(string value)
        {
            textBoxPhone.Text = value;
        }
        public void PutInEMail(string value)
        {
            textBoxEMail.Text = value;
        }
        public void PutInVk(string value)
        {
            textBoxVK.Text = value;
        }

      private void UserControl1_Load(object sender, EventArgs e)
        {
            
            labelSurnameException.Text = null;
            labelBirthdayException.Text = null;
            labelEmailException.Text = null;
            labelNameException.Text = null;
            labelPhoneException.Text = null;
            labelVkException.Text = null;
        }

        public bool CheckCorrectnessData()
        {
            bool correct = true;
            try
            {
                labelSurnameException.Text = null;
                Contact.Surname = textBoxSurname.Text;
            }
            catch (ArgumentException exception)
            {
                correct = false;
                labelSurnameException.Text = exception.Message;
            }
            try
            {
                labelNameException.Text = null;
                Contact.Name = textBoxName.Text;
            }
            catch (ArgumentException exception)
            {
                correct = false;
                labelNameException.Text = exception.Message;
            }
            try
            {
                labelBirthdayException.Text = null;
                Contact.BirthDay = dateTimeBirthDay.Value;
            }
            catch (ArgumentException exception)
            {
                correct = false;
                labelBirthdayException.Text = exception.Message;
            }
            try
            {
                labelPhoneException.Text = null;
                Contact.PhoneNumber.Number = textBoxPhone.Text;
            }
            catch (ArgumentException exception)
            {
                correct = false;
                labelPhoneException.Text = exception.Message;
            }
            try
            {
                labelEmailException.Text = null;
                Contact.EMail = textBoxEMail.Text;
            }
            catch (ArgumentException exception)
            {

                correct = false;
                labelEmailException.Text = exception.Message;
            }
            try
            {
                labelVkException.Text = null;
                Contact.VkPage = textBoxVK.Text;
            }
            catch (ArgumentException exception)
            {
                correct = false;
                labelVkException.Text = exception.Message;
            }

            return correct;
        }
    }
}
