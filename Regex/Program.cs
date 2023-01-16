namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"priyanshu@gmail.com",
          "Thakur", "abc.xyz@bl.co.in"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Email.", s,
                            RegularExpression.validEmail(s) ? "is" : "is not");
            }

        }
    }
}