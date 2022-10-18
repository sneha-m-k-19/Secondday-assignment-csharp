using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//find total number of vowels in the string
namespace Seconddayassg
{
    class Stringqst2
    {
        static void Main(string[] args)
        {
            string str2;
            //bool b;
            int count = 0;
            //string[] strg =n['a', 'e', 'i', 'o', 'u'];
            Console.WriteLine("Enter the string:");
            str2 = Console.ReadLine();
            for (int i = 0; i < str2.Length; i++)
            {  
                if (str2[i] == 'a' | str2[i]=='e' | str2[i] == 'i'| str2[i] == 'o'| str2[i] == 'u'|
                    str2[i] == 'A' | str2[i] == 'E' | str2[i] == 'I' | str2[i] == 'O' | str2[i] == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine("Count of vowels in the string \" {0} \" is :{1}",str2, count);
            Console.ReadLine();
        }
    }
}
