using ContactsAppBLL;
using System;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class MainForm : Form
    {

        private Project _project = new Project();

        public Project Project
        {
            get => _project;
            set => _project = value;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.Contact = new Contact();
            addContactForm.ShowDialog();
            if (addContactForm.CorrectExit)
            {
                var updatedContact = addContactForm.Contact;
                Project.Persons.Add(updatedContact);
                listBoxContact.Items.Add(updatedContact.Surname);
            }


        }

        /// <summary>
        /// Кнопка вызова окна изменения данных контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeParamInContact_Click(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.Contact = new Contact();
            editContactForm.Contact = Project.Persons[listBoxContact.SelectedIndex];
            editContactForm.ShowDialog();
            if (editContactForm.CorrectExit)
            {
                var updatedContact = editContactForm.Contact;
                Project.Persons[listBoxContact.SelectedIndex] = updatedContact;
                listBoxContact.Items.RemoveAt(listBoxContact.SelectedIndex);
                listBoxContact.Items.Add(updatedContact.Surname);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project = ProjectManager.LoadFromFile();
            listBoxContact.Items.Clear();

            foreach (var item in Project.Persons)
            {
                listBoxContact.Items.Add(item.Surname);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(Project);
        }

        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            var tempPerson = Project.Persons[listBoxContact.SelectedIndex];
            userControl11.PutInSurname(tempPerson.Surname);
            userControl11.PutInName(tempPerson.Name);
            userControl11.PutInBirthday(tempPerson.BirthDay);
            userControl11.PutInPhone(tempPerson.PhoneNumber.Number);
            userControl11.PutInEMail(tempPerson.EMail);
            userControl11.PutInVk(tempPerson.VkPage);
        }

        /// <summary>
        /// Кнопка удаления контакта
        /// </summary>
        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            DialogResult deleteResult = MessageBox.Show("Подтвердите удаление контакта \n Фамилия контакта: " + listBoxContact.Text, "Удаление", MessageBoxButtons.OKCancel);
            if (deleteResult == DialogResult.OK)
            {
                Project.Persons.RemoveAt(listBoxContact.SelectedIndex);
                listBoxContact.Items.RemoveAt(listBoxContact.SelectedIndex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Project = ProjectManager.LoadFromFile();
                listBoxContact.Items.Clear();

                foreach (var item in Project.Persons)
                {
                    listBoxContact.Items.Add(item.Surname);
                }
            }
            catch
            {

            }
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ProjectManager.SaveToFile(Project);
            }
            catch 
            {
                
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void sortListBox()
        {
            listBoxContact.Items.Clear();
            
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you find some bugs\n send me mailto:Stepa19991005@gmail.com", "About",MessageBoxButtons.OK);
        }
    }
}
