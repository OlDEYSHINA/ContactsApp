using ContactsAppBLL;
using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Лист отображаемых контактов
        /// </summary>
        private List<Contact> _vievsContacts;
        public MainForm()
        {
            InitializeComponent();
            Project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            _vievsContacts = Project.Contacts;
            FindAndUpdateListBox();
        }

        /// <summary>
        /// Метод вызова окна добавления контакта
        /// </summary>
        private void AddContactForm()
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Contact = new Contact();
            contactForm.ShowDialog();
            if (contactForm.CorrectExit)
            {
                var updatedContact = contactForm.Contact;
                Project.Contacts.Add(updatedContact);
                ContactMainControl.Contact = updatedContact;
                FindAndUpdateListBox();
                ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
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

            ContactForm contactForm = new ContactForm();
            contactForm.Contact = new Contact();
            contactForm.Contact = Project.Contacts[listBoxContact.SelectedIndex];
            contactForm.ShowDialog();
            if (contactForm.CorrectExit)
            {
                var updatedContact = contactForm.Contact;
                Project.Contacts[listBoxContact.SelectedIndex] = updatedContact;
                ContactMainControl.Contact = updatedContact;
                FindAndUpdateListBox();
                ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
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
                MessageBox.Show("Do you really want delete \n this contact: " + listBoxContact.Text, "Delete Contact",
                    MessageBoxButtons.OKCancel);
            if (deleteResult == DialogResult.OK)
            {
                Project.Contacts.RemoveAt(listBoxContact.SelectedIndex);
                FindAndUpdateListBox();
                ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
            }
        }

        /// <summary>
        /// Кнопка вызова окна изменения данных контакта
        /// </summary>
        private void buttonChangeParamInContact_Click(object sender, EventArgs e)
        {
            EditNewContact();
        }

        /// <summary>
        /// Эвент выбора и показа контакта в mainForm
        /// </summary>
        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            var tempContact = _vievsContacts[listBoxContact.SelectedIndex];
            ContactMainControl.Contact = tempContact;
        }

        /// <summary>
        /// Кнопка удаления контакта
        /// </summary>
        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        /// <summary>
        /// Закрытие главной формы
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Кнопка создания нового контакта
        /// </summary>
        private void ButtonСreateNewContact_Click(object sender, EventArgs e)
        {
            AddContactForm();
        }

        /// <summary>
        /// Добавить контакт по нажатию кнопки в тулбаре
        /// </summary>
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactForm();
        }

        /// <summary>
        /// Редактировать контакт по нажатию кнопки в тулбаре
        /// </summary>
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNewContact();
        }

        /// <summary>
        ///  Удалить контакт по нажатию кнопки в тулбаре
        /// </summary>
        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        /// <summary>
        ///  Выход из программы по нажатию кнопки в тулбаре
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
            Application.Exit();
        }

        /// <summary>
        /// Событие по изменению значения в строке поиска
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FindAndUpdateListBox();
        }

        /// <summary>
        /// Метод обновления лист бокса, включающий себя поиск
        /// </summary>
        private void FindAndUpdateListBox()
        {
            Project.Contacts = Project.Contacts.OrderBy(o => o.Surname).ToList();
            listBoxContact.Items.Clear();
            _vievsContacts = ProjectManager.FindInProject(FindBox.Text, Project.Contacts);
            foreach (var finded in _vievsContacts)
            {
                listBoxContact.Items.Add(finded.Surname);
            }
        }
    }
}
