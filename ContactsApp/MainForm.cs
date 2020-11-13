using ContactsAppBLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class MainForm : Form
    {
        Person test = new Person();

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
        
        private void MainForm_Load(object sender, EventArgs e)
        {
           
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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelErrorSurname_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.Surname = textBoxSurname.Text;
            test.Name = textBoxName.Text;
            test.Phone = textBoxPhone.Text;
            test.EMail = textBoxEMail.Text;
            test.VkPage = textBoxVK.Text;
            test.BirthDay = dateTimeBirthDay.Value;


        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Include;
                serializer.TypeNameHandling = TypeNameHandling.All;
                serializer.Formatting = Formatting.None;
                using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ContactApp\Contacts.txt"))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
            }
           }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ContactApp\Contacts.txt");
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.TypeNameHandling = TypeNameHandling.All;
            serializer.Formatting = Formatting.None;
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ContactApp\Contacts.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, Project);
            };
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

        private void textBoxEMail_TextChanged(object sender, EventArgs e)
        {

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
