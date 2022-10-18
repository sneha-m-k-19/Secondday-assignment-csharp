using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Find total number od words in a string
namespace Seconddayassg
{
    class Stringqst1
    {       
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter the string:");
            str1 = Console.ReadLine();
            string[] starray= str1.Split( );
            Console.Write("No of words in the string \" {0} \" is : ", str1);
            Console.Write(starray.Length);
            Console.ReadLine();
        }
    }
}
