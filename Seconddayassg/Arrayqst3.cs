using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to store all negative elements in an array to another
namespace Seconddayassg
{
    class Arrayqst3
    {
        static void Main(string[] args)
        {
            int[] array3 = new int[] { -20, 33, 40, -34, 99, -56, 32 };
            int j = 0,count=0;
            Console.WriteLine("Actual Array :");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
                if (array3[i] < 0)
                {
                    count ++;
                }
            }
            int[] negarray = new int[count];
            for (int i = 0; i < array3.Length; i++)
            {                
                if (array3[i]<0)
                {
                    negarray[j] = array3[i];
                    j++;
                }
            }
            Console.WriteLine("New Array is :");
            for (int i = 0; i < negarray.Length; i++)
            {
                Console.WriteLine(negarray[i]);                 
            }
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
