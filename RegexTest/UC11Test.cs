using Regexp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTest
{
    [TestClass]
    public class UC11Test
    {
        [TestMethod]
        [DataRow("john.doe@example.com", true)]
        [DataRow("johndoeexample.com", false)]
        [DataRow("john.doe@example", false)]
        [DataRow("", false)]
        public void Test_ValidateEmail(string email, bool expectedResult)
        {
            // Act
            bool isValid = UserEntryValidator.IsValidEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, isValid);
        }

    }
}
