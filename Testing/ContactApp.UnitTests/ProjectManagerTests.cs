using ContactsAppBLL;
using System;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        [Test]
        public void ProjectManager_GoodSave_Nothing()
        {
            //setup
            var project = new Project();
            var contact = new Contact();
            contact.Name = "James";
            contact.Surname = "Johnson";
            contact.BirthDay = new DateTime(2008,4,2,4,2,4);
            contact.EMail = "Jorno@gmail.com";
            contact.PhoneNumber.Number = "+79131111600";
            contact.VkPage = "CutJohnson";
            var projectNew = new Project();

            // Act
            project.Contacts.Add(contact);
            ProjectManager.SaveToFile(project);
            projectNew = ProjectManager.LoadFromFile();

            // Assert
            NUnit.Framework.Assert.AreEqual(project.Contacts[0].Name,projectNew.Contacts[0].Name);
            NUnit.Framework.Assert.AreEqual(project.Contacts[0].Surname, projectNew.Contacts[0].Surname);
            NUnit.Framework.Assert.AreEqual(project.Contacts[0].BirthDay, projectNew.Contacts[0].BirthDay);
            NUnit.Framework.Assert.AreEqual(project.Contacts[0].EMail, projectNew.Contacts[0].EMail);
            NUnit.Framework.Assert.AreEqual(project.Contacts[0].VkPage, projectNew.Contacts[0].VkPage);
            NUnit.Framework.Assert.AreEqual(project.Contacts[0].PhoneNumber.Number, projectNew.Contacts[0].PhoneNumber.Number);
        }
    }
}
