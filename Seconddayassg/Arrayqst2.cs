using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to find sum of array elements
namespace Seconddayassg
{
    class Arrayqst2
    {
        static void Main(string[] args)
        {
            int[] array2 = new int[] { 20, 43, 31, 34, 89, 56, 32 };
            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum = sum + array2[i];

            }
            Console.WriteLine("Sum of elements in array2 is :{0}", sum);
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
