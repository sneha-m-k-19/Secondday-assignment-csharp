using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program to count even and odd elements in the array
namespace Seconddayassg
{
    class Arrayqst1
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 20, 43, 31, 34, 89, 56, 32 };
            int e_count = 0, o_count = 0;
            for(int i=0;i<array1.Length;i++)
            {
                if ((array1[i]%2)==0)
                {
                    e_count++;
                }
                else
                {
                    o_count++;
                }

            }
            Console.WriteLine("Count of even number in array : {0}\nCount of odd numbers in array : {1}", e_count, o_count);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
