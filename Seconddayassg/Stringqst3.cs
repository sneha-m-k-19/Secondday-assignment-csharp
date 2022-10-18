using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to check whether a given substring is present in the given string
namespace Seconddayassg
{
    class Stringqst3
    {
        static void Main(string[] args)
        {
            string str1,str2;
            Console.WriteLine("Enter the string:");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the sub string:");
            str2= Console.ReadLine();
            if(str1.Contains(str2))
            {
                Console.WriteLine("string \" {0} \" is a substring of  string \" {1} \" : ", str2,str1);
            }
            else
            {
                Console.WriteLine("string \" {0} \" is not a substring of  string \" {1} \"  : ", str2, str1);
            }
            Console.WriteLine("Press enter key to exit");
            Console.ReadLine();
        }
    }
}
