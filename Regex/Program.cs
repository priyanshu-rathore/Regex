namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"priyanshu@gmail.com",
          "91 9826153411", "abc.xyz@bl.co.in"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Number.", s,
                            RegularExpression.validNumber(s) ? "is" : "is not");
            }

        }
    }
}