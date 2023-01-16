namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Email.", s,
                            RegularExpression.validEmail(s) ? "is" : "is not");
            }

        }
    }
}