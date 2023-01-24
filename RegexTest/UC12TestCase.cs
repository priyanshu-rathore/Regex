using Regexp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Regexp.UserEntryValidator;

namespace RegexTest
{
    [TestClass]
    public class UC12TestCase
    {
        [TestMethod]
        public void HappyTest_ValidateUserEntry()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "john.doe@example.com";
            string mobile = "5555555555";
            string password = "P@ssw0rd";

            // Act
            UserEntryValidator.Validate(firstName, lastName, email, mobile, password);

            // Assert
            // No exception should be thrown
        }

        [TestMethod]
        public void SadTest_InvalidFirstName()
        {
            // Arrange
            string firstName = "";
            string lastName = "Doe";
            string email = "john.doe@example.com";
            string mobile = "555-555-5555";
            string password = "P@ssw0rd";

            // Act
            try
            {
                UserEntryValidator.Validate(firstName, lastName, email, mobile, password);
                Assert.Fail("Expected InvalidUserDetailException to be thrown");
            }
            catch (InvalidUserDetailException ex)
            {
                Assert.AreEqual("Invalid first name", ex.Message);
            }
        }

        [TestMethod]
        public void SadTest_InvalidEmail()
        {
            //Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "johndoeexample.com";
            string mobile = "555-555-5555";
            string password = "P@ssw0rd";

            // Act
            try
            {
                UserEntryValidator.Validate(firstName, lastName, email, mobile, password);
                Assert.Fail("Expected InvalidUserDetailException to be thrown");
            }
            catch (InvalidUserDetailException ex)
            {
                Assert.AreEqual("Invalid email address", ex.Message);
            }


        }
    }
}