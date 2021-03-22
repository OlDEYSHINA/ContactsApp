using ContactsAppBLL;
using NUnit.Framework;
using System;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [Test]
        public void Name_GoodName_ReturnsSameName()
        {
            // setup
            var contact = new Contact();
            var sourceName = "James";
            var expectedName = sourceName;

            // Act
            contact.Name = sourceName;
            var actualName = contact.Name;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Name_UpperSymbolsCorrect_ThrowsException()
        {
            // setup
            var contact = new Contact();
            var sourceName = "jaMeS";

            // Assertы
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.Name = sourceName;
                }
                );
        }

        [Test]
        public void Name_EmptyName_ThrowsException()
        {
            // setup
            var contact = new Contact();
            var sourceName = "";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.Name = sourceName;
                }
            );
        }

        [Test]
        public void Surname_GoodSurname_ReturnsSameSurname()
        {
            // setup
            var contact = new Contact();
            var sourceSurname = "Johnson";
            var expectedSurname = sourceSurname;

            // Act
            contact.Surname = sourceSurname;
            var actualSurname = contact.Surname;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedSurname, actualSurname);
        }

        [Test]
        public void Surname_UpperSymbolsCorrect_ThrowsException()
        {
            // setup
            var contact = new Contact();
            var sourceSurname = "jaMeS";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.Surname = sourceSurname;
                }
            );
        }

        [Test]
        public void Surname_EmptySurname_ThrowsException()
        {
            // setup
            var contact = new Contact();
            var sourceSurname = "";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.Surname = sourceSurname;
                }
            );
        }

        [Test]
        public void EMail_GoodEMail_ReturnsSameEMail()
        {
            // setup
            var contact = new Contact();
            var sourceEMail = "Linkoln@gmail.com";
            var expectedEMail = sourceEMail;

            // Act
            contact.EMail = sourceEMail;
            var actualEMail = contact.EMail;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedEMail, actualEMail);
        }

        [Test]
        public void EMail_EmptyEMail_ThrowsException()
        {
            // setup
            var contact = new Contact();
            var sourceEMail = "";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.EMail = sourceEMail;
                }
            );
        }

        // Check PhoneNumber parameters
        [Test]
        public void PhoneNumber_ContainSymbols_ThrowsException()
        {
            // setup
            var contact = new Contact();
            contact.PhoneNumber = new PhoneNumber();
            var sourcePhoneNumber = "jaMeS";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.PhoneNumber.Number = sourcePhoneNumber;
                }
            );
        }

        [TestCase("+79131111600")]
        [TestCase("89131111600")]
        public void PhoneNumber_GoodNumber_ReturnsSamePhoneNumber(string value)
        {
            // setup
            var contact = new Contact();
            var sourcePhoneNumber = value;
            var expectedPhoneNumber = sourcePhoneNumber;

            // Act
            contact.PhoneNumber.Number = sourcePhoneNumber;
            var actualPhoneNumber = contact.PhoneNumber.Number;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
        }

        [Test]
        public void PhoneNumber_EmptyNumber_ThrowException()
        {
            // setup
            var contact = new Contact();
            var sourcePhoneNumber = "";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.PhoneNumber.Number = sourcePhoneNumber;
                }
            );
        }

        [TestCase("+89131111600")]
        [TestCase("79131111600")]
        [TestCase("JoJoReference")]
        public void PhoneNumber_UnCorrectNumber_ThrowException(string value)
        {
            // setup
            var contact = new Contact();
            var sourcePhoneNumber = value;

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.PhoneNumber.Number = sourcePhoneNumber;
                }
            );
        }
      
        [Test]
        public void PhoneNumber_TooLongNumber_ThrowException()
        {
            // setup
            var contact = new Contact();
            var sourcePhoneNumber = "791311116005465";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.PhoneNumber.Number = sourcePhoneNumber;
                }
            );
        }

        [Test]
        public void VkPage_EmptyVkPage_ThrowException()
        {
            // setup
            var contact = new Contact();
            var sourceVkPage = "";

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.VkPage = sourceVkPage;
                }
            );
        }

        [Test]
        public void VkPage_GoodVkPage_ReturnsSameVkPage()
        {
            // setup
            var contact = new Contact();
            var sourceVkPage = "MashmashiGalochka";
            var expectedVkPage = sourceVkPage;

            // Act
            contact.VkPage = sourceVkPage;
            var actualVkPage = contact.VkPage;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedVkPage, actualVkPage);
        }

        [Test]
        public void BirthDay_GoodBirthDay_ReturnsSameBirthDay()
        {
            // setup
            var contact = new Contact();
            var sourceBirthDay = new DateTime(2008, 6, 1);
            var expectedBirthDay = sourceBirthDay;

            // Act
            contact.BirthDay = sourceBirthDay;
            var actualBirthDay = contact.BirthDay;

            // Assert
            NUnit.Framework.Assert.AreEqual(expectedBirthDay, actualBirthDay);
        }
        [Test]
        public void VkPage_FutureDate_ThrowException()
        {
            // setup
            var contact = new Contact();
            var sourceBirthDay = new DateTime(2200, 6, 1);

            // Assert
            NUnit.Framework.Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.BirthDay = sourceBirthDay;
                }
            );
        }
    }
}
