using System.Text;

namespace AddingTypesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            //char[] symbols1 = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Console.WriteLine(new String(str.ToCharArray(), 4, 5));

            string strTrim = "_*-+=#";
            str = "++++Hello==--";
            Console.WriteLine(str.Trim(strTrim.ToCharArray()));

            str = "Bob Joe Tim Tom Sam";
            var names = str.Split(' ');

            foreach(var name in names)
                Console.WriteLine(name);

            string[] days = new string[] { "monaday", "tueasday" };

            string bigDay = String.Join('/', days);
            Console.WriteLine(bigDay);

            int a = 100;

            str = $"{100 + 200 / a}";
            str = @"C:\Program Files";

            StringBuilder sb = new StringBuilder("Hello");

            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
        }
    }
}