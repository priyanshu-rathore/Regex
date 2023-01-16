using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexp
{
    internal class RegularExpression
    {
        public static bool validation(string validator)//UC1 UC2
        {
            string pattern = "^[A-Z]{1}[a-z]{2,10}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(validator))
                return (true);
            else
                return (false);
        }

        public static bool validEmail(string email)//UC3
        {
            string pattern = "^[a-z]{1,10}(.|)[a-z]{1,10}@[a-z]{1,10}(.|)[a-z]{1,10}(.|)[a-z]{1,10}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(email))
                return (true);
            else
                return (false);

        }

        public static bool validNumber(string number)//UC4
        {
            string pattern = "^[0-9]{1,4} [0-9]{10}$";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(number))
                return (true);
            else
                return (false);
        }
    }
}
