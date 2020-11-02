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
            var names = new Dictionary<string, Person>();
            string _saveName = "jopa";
            names[_saveName] = new Person();

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
    }
}
