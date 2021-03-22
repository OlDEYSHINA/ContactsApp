using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ContactsAppBLL;
using NUnit.Framework;


namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {

        public string testPath()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(location) + @"\TestData";
        }

        public Project PrepareProject()
        {
            var project = new Project();
            var contact = new Contact();
            contact.Name = "James";
            contact.Surname = "Johnson";
            contact.BirthDay = new DateTime(2008, 4, 2, 4, 2, 4);
            contact.EMail = "Jorno@gmail.com";
            contact.PhoneNumber.Number = "+79131111600";
            contact.VkPage = "CutJohnson";
            project.Contacts.Add(contact);
            return project;
        }

        [Test]
        public void SaveToFile_CorrectProject_CorrectSave()
        {
            //Setup
            var sourceProject = PrepareProject();
            var testDataFolder = testPath();
            var actualFileName = testDataFolder + @"\actualProject.json";
            var expectedFileName = testDataFolder + @"\expectedProject.json";

            if (File.Exists(actualFileName))
            {
                File.Delete(actualFileName);
            }

            //Act
            ProjectManager.SaveToFile(sourceProject,actualFileName);
            var isFileExist = File.Exists(actualFileName);
            NUnit.Framework.Assert.AreEqual(true,isFileExist);
            //Assert
            var actualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFileName);
            NUnit.Framework.Assert.AreEqual(expectedFileContent,actualFileContent);
        }

        [Test]
        public void LoadFromFile_CorrectProject_CorrectLoad()
        {
            //setup
            var sourceProject = PrepareProject();
            var loadFileName = testPath() + @"\expectedProject.json";

            //Act
            var LoadedProject = ProjectManager.LoadFromFile(loadFileName);

            //Assert
            Assert.AreEqual(LoadedProject.Contacts[0].Surname,sourceProject.Contacts[0].Surname);
            Assert.AreEqual(LoadedProject.Contacts[0].Name, sourceProject.Contacts[0].Name);
            Assert.AreEqual(LoadedProject.Contacts[0].BirthDay, sourceProject.Contacts[0].BirthDay);
            Assert.AreEqual(LoadedProject.Contacts[0].EMail, sourceProject.Contacts[0].EMail);
            Assert.AreEqual(LoadedProject.Contacts[0].VkPage, sourceProject.Contacts[0].VkPage);
            Assert.AreEqual(LoadedProject.Contacts[0].PhoneNumber.Number, sourceProject.Contacts[0].PhoneNumber.Number);
        }

        [Test]
        public void LoadFromFile_MissingFile_CorrectCreateEmptyProject()
        {
            //Setup
            var loadFileName = testPath() + @"\MissingFile.json";

            //Act
            var LoadedProject = ProjectManager.LoadFromFile(loadFileName);

            //Assert
            if (LoadedProject.Contacts.Count != 0) throw new ArgumentException();
        }
    }
}
