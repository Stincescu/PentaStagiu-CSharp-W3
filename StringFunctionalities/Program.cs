using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionalities
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "PentaStagiu2019";
            string str2 = "PentaStagiu2020";
            string str4 = "Particip la PentaStagiu2019";

            //Functionality(1)
            string lower1 = str1.ToLower();
            Console.WriteLine(lower1);
            Console.WriteLine("\n");
            //Functionality(2)
            string upper2 = str2.ToUpper();
            Console.WriteLine(upper2);
            Console.WriteLine("\n");
            //Functionality(3)
            string str3 = string.Concat(str1, str2);
            Console.WriteLine(str3);
            Console.WriteLine("\n");
            //Functionality(4)
            string trimmed = str1.TrimEnd('2','0','1','9');
            Console.WriteLine(trimmed);
            Console.WriteLine("\n");
            //Functionality(5)
            string[] words = str4.Split(' ');
            foreach(string word in words)
            {
                Console.WriteLine("WORD:" + word);
            }
            Console.WriteLine("\n");
            //Functionality(6)
            string substring = str1.Substring(0, 5);
            Console.WriteLine($"Substring: {substring}");
            Console.WriteLine("\n");
            //Functionality(7)
            int index = str1.LastIndexOf('S');
            if (index != -1)
            {
                Console.WriteLine(index);
                Console.WriteLine(str1.Substring(index));
            }
        }
    }
}
