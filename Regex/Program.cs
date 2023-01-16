namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"Rathore",
          "Thakur", "Singh"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Last Name.", s,
                            RegularExpression.validation(s) ? "is" : "is not");
            }

        }
    }
}