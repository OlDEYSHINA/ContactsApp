using ContactsAppBLL;
using Newtonsoft.Json;
using System;
using System.IO;
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
            addContactForm.Person = new Person();
            addContactForm.ShowDialog();
            if (addContactForm.CorrectExit)
            {
                var updatedContact = addContactForm.Person;
                Project.Persons.Add(updatedContact);
                listBoxContact.Items.Add(updatedContact.Surname);
            }


        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.LoadFromFile();
            listBoxContact.Items.Clear();
            
            foreach (var item in Project.Persons)
            {
                listBoxContact.Items.Add(item.Surname);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.SaveToFile(Project);
        }

        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            Person tempPerson = new Person();
            tempPerson = Project.Persons[listBoxContact.SelectedIndex];
            textBoxSurname.Text = tempPerson.Surname;
            textBoxName.Text = tempPerson.Name;
            dateTimeBirthDay.Value = tempPerson.BirthDay;
            textBoxEMail.Text = tempPerson.EMail;
            textBoxPhone.Text = tempPerson.Phone;
            textBoxVK.Text = tempPerson.VkPage;
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
    }
}
