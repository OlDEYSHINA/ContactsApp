using ContactsAppBLL;
using System;
using System.Linq;
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

        /// <summary>
        /// Метод вызова окна добавления контакта
        /// </summary>
        private void AddNewContact()
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.Contact = new Contact();
            addContactForm.ShowDialog();
            if (addContactForm.CorrectExit)
            {
                var updatedContact = addContactForm.Contact;
                Project.Contacts.Add(updatedContact);
                listBoxContact.Items.Add(updatedContact.Surname);
                sortAndWriteListBox();
            }
        }

        /// <summary>
        /// Метод вызова окна изменения контакта
        /// </summary>
        private void EditNewContact()
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.Contact = new Contact();
            addContactForm.Contact = Project.Contacts[listBoxContact.SelectedIndex];
            addContactForm.ShowDialog();
            if (addContactForm.CorrectExit)
            {
                var updatedContact = addContactForm.Contact;
                Project.Contacts[listBoxContact.SelectedIndex] = updatedContact;
                sortAndWriteListBox();
            }
        }

        /// <summary>
        /// Метод удаления контакта 
        /// </summary>
        private void DeleteContact()
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }

            DialogResult deleteResult =
                MessageBox.Show("Подтвердите удаление контакта \n Фамилия контакта: " + listBoxContact.Text, "Удаление",
                    MessageBoxButtons.OKCancel);
            if (deleteResult == DialogResult.OK)
            {
                Project.Contacts.RemoveAt(listBoxContact.SelectedIndex);
                sortAndWriteListBox();
            }
        }

        /// <summary>
    /// Кнопка вызова окна изменения данных контакта
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonChangeParamInContact_Click(object sender, EventArgs e)
        {
            EditNewContact();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project = ProjectManager.LoadFromFile();
            listBoxContact.Items.Clear();

            foreach (var item in Project.Contacts)
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
            var tempContact = Project.Contacts[listBoxContact.SelectedIndex];
            userControl11.PutInSurname(tempContact.Surname);
            userControl11.PutInName(tempContact.Name);
            userControl11.PutInBirthday(tempContact.BirthDay);
            userControl11.PutInPhone(tempContact.PhoneNumber.Number);
            userControl11.PutInEMail(tempContact.EMail);
            userControl11.PutInVk(tempContact.VkPage);
        }

        /// <summary>
        /// Кнопка удаления контакта
        /// </summary>
        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
           DeleteContact();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Project = ProjectManager.LoadFromFile();
                sortAndWriteListBox();
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

        private void sortAndWriteListBox()
        {
            Project.Contacts = Project.Contacts.OrderBy(o => o.Surname).ToList();
            listBoxContact.Items.Clear();
            foreach (var item in Project.Contacts)
            {
                listBoxContact.Items.Add(item.Surname);
            }

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you find some bugs\n send me mailto:Stepa19991005@gmail.com", "About", MessageBoxButtons.OK);
        }

        private void buttonСreateNewContact_Click(object sender, EventArgs e)
        {
            AddNewContact();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewContact();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNewContact();
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }
    }
}
