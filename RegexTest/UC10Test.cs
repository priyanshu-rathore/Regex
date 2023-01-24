using Regexp;

namespace RegexTest
{
    [TestClass]
    public class UC10Test
    {
        [TestMethod]
        public void HappyTest_ValidateUserEntry()
        {
            // Arrange
            string firstName = "Priyanshu";
            string lastName = "Rathore";
            string email = "priyanshurathore132@gmail.com";
            string mobile = "9826153411";
            string password = "P@ssw0rd";

            // Act
            bool isValid = UserEntryValidator.Validate(firstName, lastName, email, mobile, password);

            // Assert
            Assert.IsTrue(isValid);
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
            bool isValid = UserEntryValidator.Validate(firstName, lastName, email, mobile, password);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void SadTest_InvalidEmail()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string email = "johndoeexample.com";
            string mobile = "555-555-5555";
            string password = "P@ssw0rd";

            // Act
            bool isValid = UserEntryValidator.Validate(firstName, lastName, email, mobile, password);

            // Assert
            Assert.IsFalse(isValid);
        }

    }
}