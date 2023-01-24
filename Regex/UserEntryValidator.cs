using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexp
{
    public static class UserEntryValidator//UC10
    {
        public static bool Validate(string firstName, string lastName, string email, string mobile, string password)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new InvalidUserDetailException("Invalid first name");

            if (string.IsNullOrEmpty(lastName))
                throw new InvalidUserDetailException("Invalid last name");

            if (!IsValidEmail(email))
                throw new InvalidUserDetailException("Invalid email address");

            if (!IsValidMobile(mobile))
                throw new InvalidUserDetailException("Invalid mobile number");

            if (!IsValidPassword(password))
                throw new InvalidUserDetailException("Invalid password");

            return true;
        }

        private static bool IsValidFirstName(string firstName)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,10}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(firstName))
                return (true);
            else
                return (false);
        }

        private static bool IsValidLastName(string lastName)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,10}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(lastName))
                return (true);
            else
                return (false);
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = "^[a-z0-9]{1,}(.|-|)[a-z0-9]{1,}@[a-z0-9]{1,}(.|)[a-z0-9]{1,}[.]{1}[a-z]{1,}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(email))
                return (true);
            else
                return (false);
        }

        private static bool IsValidMobile(string mobile)
        {
            string pattern = "^[0-9]{10}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(mobile))
                return (true);
            else
                return (false);
        }

        private static bool IsValidPassword(string password)
        {
            string pattern = "^[A-Za-z0-9@#$%^&+!=]{8,}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(password))
                return (true);
            else
                return (false);
        }

        public class InvalidUserDetailException : Exception
        {
            public InvalidUserDetailException(string message) : base(message) { }
        }
    }

}
