using ContactsAppBLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class ContactControl : UserControl
    {
        private Contact _contact;
        ToolTip surNameToolTip = new ToolTip();
        ToolTip nameToolTip = new ToolTip();
        private System.Windows.Forms.ErrorProvider dateErrorProvider;
        ToolTip dateToolTip = new ToolTip();
        ToolTip phoneToolTip = new ToolTip();
        ToolTip eMailToolTip = new ToolTip();
        ToolTip vkToolTip = new ToolTip();
       
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if (value != null)
                {
                    if (!string.IsNullOrEmpty(Contact.Surname))
                    {

                        textBoxSurname.Text = Contact.Surname;
                        textBoxName.Text = Contact.Name;
                        dateTimeBirthDay.Value = Contact.BirthDay;
                        textBoxPhone.Text = Contact.PhoneNumber.Number;
                        textBoxEMail.Text = Contact.EMail;
                        textBoxVK.Text = Contact.VkPage;
                    }
                }
            }
        }
        public ContactControl()
        {
            InitializeComponent();
            dateErrorProvider = new ErrorProvider();
        }

        /// <summary>
        /// Заполнить контакт контрол
        /// </summary>
      
        public bool CheckCorrectnessData()
        {
            var correct = true;
            try
            {
                Contact.Surname = textBoxSurname.Text;                              //SURNAME
            }
            catch (ArgumentException exception)
            {
                surNameToolTip.SetToolTip(textBoxSurname, exception.Message);
                textBoxSurname.BackColor = Color.LightCoral;
                correct = false;
            } 
            try
            {
                Contact.Name = textBoxName.Text;                                    //Name
            }
            catch (ArgumentException exception)
            {
                nameToolTip.SetToolTip(textBoxName, exception.Message);
                textBoxName.BackColor = Color.LightCoral;
                correct = false;
            } 
            try
            {
                Contact.BirthDay =dateTimeBirthDay.Value;                           //BirthDay
            }
            catch (ArgumentException exception)
            {
                dateErrorProvider.SetIconAlignment(dateTimeBirthDay, ErrorIconAlignment.MiddleRight);
                dateErrorProvider.SetIconPadding(dateTimeBirthDay, 2);
                dateErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                dateErrorProvider.SetError(dateTimeBirthDay, exception.Message);
                correct = false;
            } 
            try
            {
                Contact.PhoneNumber.Number = textBoxPhone.Text;                              //Phone
            }
            catch (ArgumentException exception)
            {
                phoneToolTip.SetToolTip(textBoxPhone, exception.Message);
                textBoxPhone.BackColor = Color.LightCoral;
                correct = false;
            } 
            try
            {
                Contact.EMail = textBoxEMail.Text;                              //Email
            }
            catch (ArgumentException exception)
            {
                eMailToolTip.SetToolTip(textBoxEMail, exception.Message);
                textBoxEMail.BackColor = Color.LightCoral;
                correct = false;
            }  
            try
            {
                Contact.VkPage = textBoxVK.Text;                              //VkPage
            }
            catch (ArgumentException exception)
            {
                vkToolTip.SetToolTip(textBoxVK, exception.Message);
                textBoxVK.BackColor = Color.LightCoral;
                correct = false;
            }
            return correct;
        }
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            
            string exceptionText = "";
            surNameToolTip.Hide(textBoxSurname);
            surNameToolTip.ReshowDelay = 0;
            surNameToolTip.InitialDelay = 10;
            try
            {
                Contact.Surname = textBoxSurname.Text;
            }
            catch (ArgumentException exception)
            {
              exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxSurname.BackColor = Color.White;
                surNameToolTip.RemoveAll();
            }
            else
            {
                surNameToolTip.SetToolTip(textBoxSurname,exceptionText);
                textBoxSurname.BackColor = Color.LightCoral;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            
            string exceptionText = "";
            nameToolTip.ReshowDelay = 0;
            nameToolTip.InitialDelay = 10;
            try
            {
                Contact.Name = textBoxName.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxName.BackColor = Color.White;
                
            }
            else
            {
                nameToolTip.SetToolTip(textBoxName, exceptionText);
                textBoxName.BackColor = Color.LightCoral;
            }
        }

        private void dateTimeBirthDay_ValueChanged(object sender, EventArgs e)
        {
            dateErrorProvider.SetError(dateTimeBirthDay,null);
            try
            {
                Contact.BirthDay = dateTimeBirthDay.Value;
            }
            catch (Exception exception)
            {
               
                dateErrorProvider.SetIconAlignment(dateTimeBirthDay, ErrorIconAlignment.MiddleRight);
                dateErrorProvider.SetIconPadding(dateTimeBirthDay, 2);
                dateErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                dateErrorProvider.SetError(dateTimeBirthDay, exception.Message);
            }
         
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string exceptionText = "";
            phoneToolTip.ReshowDelay = 0;
            phoneToolTip.InitialDelay = 10;
            try
            {
                Contact.PhoneNumber.Number = textBoxPhone.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxPhone.BackColor = Color.White;

            }
            else
            {
                phoneToolTip.SetToolTip(textBoxPhone, exceptionText);
                textBoxPhone.BackColor = Color.LightCoral;
            }
        }

        private void textBoxEMail_TextChanged(object sender, EventArgs e)
        {
            string exceptionText = "";
            eMailToolTip.ReshowDelay = 0;
            eMailToolTip.InitialDelay = 10;
            try
            {
                Contact.EMail = textBoxEMail.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxEMail.BackColor = Color.White;

            }
            else
            {
                eMailToolTip.SetToolTip(textBoxEMail, exceptionText);
                textBoxEMail.BackColor = Color.LightCoral;
            }
        }

        private void textBoxVK_TextChanged(object sender, EventArgs e)
        {
            string exceptionText = "";
            vkToolTip.ReshowDelay = 0;
            vkToolTip.InitialDelay = 10;
            try
            {
                Contact.VkPage = textBoxVK.Text;
            }
            catch (ArgumentException exception)
            {
                exceptionText = exception.Message;
            }
            if (string.IsNullOrEmpty(exceptionText))
            {
                textBoxVK.BackColor = Color.White;

            }
            else
            {
                vkToolTip.SetToolTip(textBoxVK, exceptionText);
                textBoxVK.BackColor = Color.LightCoral;
            }
        }
    }
}
