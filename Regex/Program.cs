namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"Priyanshu",
          "Naveen", "Rupali"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Name.", s,
                            RegularExpression.validation(s) ? "is" : "is not");
            }

        }
    }
}