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
            labelErrorName.Text = null;
            labelErrorSurname.Text = null;
            labelErrorBirthday.Text = null;
            labelErrorEMail.Text = null;
            labelErrorPhone.Text = null;
            labelErrorVK.Text = null;
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
            labelErrorSurname.Text = test.Label;
            test.Name = textBoxName.Text;
            labelErrorName.Text = test.Label;
            test.Phone = textBoxPhone.Text;
            labelErrorPhone.Text = test.Label;
            test.EMail = textBoxEMail.Text;
            labelErrorEMail.Text = test.Label;
            test.VkPage = textBoxVK.Text;
            labelErrorVK.Text = test.Label;
            test.BirthDay = dateTimeBirthDay.Value;


        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person test = null;
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(@"Contacts.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                test = (Person)serializer.Deserialize<Person>(reader);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(@"Contacts.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, test);
            }
        }

        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person tempPerson = new Person();
            tempPerson = Project.Persons[listBoxContact.SelectedIndex];
            textBoxSurname.Text = tempPerson.Surname;
            textBoxName.Text = tempPerson.Name;
            dateTimeBirthDay.Value = tempPerson.BirthDay;
            textBoxEMail.Text = tempPerson.EMail;
            textBoxPhone.Text = tempPerson.Phone;
            textBoxVK.Text = tempPerson.VkPage;
        }
    }
}
