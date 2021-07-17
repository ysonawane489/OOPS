using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class StringFunctions
    {
        public static void functions()
        {
            string str1 = "Yogesh";
            string str2 = "Sonawane";
            Console.WriteLine("-----clone()-----");
            string c =(String) str1.Clone();
            Console.WriteLine(str1);
            Console.WriteLine(c);

            Console.WriteLine("-----Copmpare()-----");

            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));
            Console.WriteLine("-----CopmpareTO()-----");
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s3));

            Console.WriteLine("-----Concat()-----");
            Console.WriteLine(string.Concat(str1, str2));
            Console.WriteLine("---contains()----");
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(" ----copy()---");
            string cp = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(cp);

            Console.WriteLine("Hashcode :" + str1.GetHashCode());

            Console.WriteLine("copyTo Array");
            string str5 = "India is My country";
            Console.WriteLine(str5);
            char[] charArr = str5.ToCharArray();
            foreach(char cc in charArr)
                {
                Console.WriteLine(cc);
                  }
         
            
            string end = "sh";
            Console.WriteLine(str1+" EndWith() "+end);
            Console.WriteLine(str1.EndsWith(end));
            Console.WriteLine("length :" + str1.Length);
            Console.WriteLine("ToUpper :" + str1.ToUpper());
            Console.WriteLine("ToLowe :" + str1.ToLower());

        }
    }


}
