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
            SortAndWriteListBox();
            _vievsContacts = Project.Contacts;

        }

        /// <summary>
        /// Метод вызова окна добавления контакта
        /// </summary>
        private void AddNewContact()
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            addEditContactForm.Contact = new Contact();
            addEditContactForm.ShowDialog();
            if (addEditContactForm.CorrectExit)
            {
                var updatedContact = addEditContactForm.Contact;
                Project.Contacts.Add(updatedContact);
                listBoxContact.Items.Add(updatedContact.Surname);
                ContactMainControl.Contact = updatedContact;
                ContactMainControl.FillContact();
                SortAndWriteListBox();
                listBoxContact.Items.Clear();
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    _vievsContacts = Project.Contacts;
                    foreach (var item in _vievsContacts)
                    {
                        listBoxContact.Items.Add(item.Surname);
                    }
                    ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
                    return;
                }
                _vievsContacts = Project.Contacts.FindAll(o => o.Surname.Contains(textBox1.Text));
                foreach (var finded in _vievsContacts)
                {
                    listBoxContact.Items.Add(finded.Surname);
                }
            }
            ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
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
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            addEditContactForm.Contact = new Contact();
            addEditContactForm.Contact = Project.Contacts[listBoxContact.SelectedIndex];
            addEditContactForm.ShowDialog();
            if (addEditContactForm.CorrectExit)
            {
                var updatedContact = addEditContactForm.Contact;
                Project.Contacts[listBoxContact.SelectedIndex] = updatedContact;
                SortAndWriteListBox();
                ContactMainControl.Contact = updatedContact;
                ContactMainControl.FillContact();
                listBoxContact.Items.Clear();
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    _vievsContacts = Project.Contacts;
                    foreach (var item in _vievsContacts)
                    {
                        listBoxContact.Items.Add(item.Surname);
                    }
                    ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
                    return;
                }
                _vievsContacts = Project.Contacts.FindAll(o => o.Surname.Contains(textBox1.Text));
                foreach (var finded in _vievsContacts)
                {
                    listBoxContact.Items.Add(finded.Surname);
                }
            }
            ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
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
                SortAndWriteListBox();
                listBoxContact.Items.Clear();
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    _vievsContacts = Project.Contacts;
                    foreach (var item in _vievsContacts)
                    {
                        listBoxContact.Items.Add(item.Surname);
                    }
                    ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
                    return;
                }
                _vievsContacts = Project.Contacts.FindAll(o => o.Surname.Contains(textBox1.Text));
                foreach (var finded in _vievsContacts)
                {
                    listBoxContact.Items.Add(finded.Surname);
                }
            }
            ProjectManager.SaveToFile(Project, ProjectManager.DefaultPath);
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

        /// <summary>
        /// Эвент выбора и показа контакта в mainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex == -1)
            {
                return;
            }
            var tempContact = _vievsContacts[listBoxContact.SelectedIndex];
            ContactMainControl.Contact = tempContact;
            ContactMainControl.FillContact();
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

        /// <summary>
        /// Метод сортировки списка контактов по фамилии
        /// </summary>
        private void SortAndWriteListBox()
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
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Кнопка создания нового контакта
        /// </summary>
        private void ButtonСreateNewContact_Click(object sender, EventArgs e)
        {
            AddNewContact();
        }

        /// <summary>
        /// Добавить контакт по нажатию кнопки в тулбаре
        /// </summary>
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewContact();
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBoxContact.Items.Clear();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                _vievsContacts = Project.Contacts;
                foreach (var item in _vievsContacts)
                {
                    listBoxContact.Items.Add(item.Surname);
                }
                return;
            }
            _vievsContacts = Project.Contacts.FindAll(o => o.Surname.Contains(textBox1.Text));
            foreach (var finded in _vievsContacts)
            {
                listBoxContact.Items.Add(finded.Surname);
            }
        }
    }
}
