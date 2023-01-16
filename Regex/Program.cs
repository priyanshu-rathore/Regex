namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"LetMeinSyste@m1",
          "P2345678", "abc.xyz@bl.co.in"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Password.", s,
                            RegularExpression.validPassword(s) ? "is" : "is not");
            }

        }
    }
}