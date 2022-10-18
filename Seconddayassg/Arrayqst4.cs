using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to sort an array
namespace Seconddayassg
{
    class Arrayqst4
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the size of the array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array4 = new int[n] ;
            Console.WriteLine("Enter the {0} to the array:",n);
            for ( int i=0;i<n;i++)
            {
                array4[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array before sorting");
            for (int i = 0; i < array4.Length; i++)
            {
                Console.WriteLine(array4[i]);
            }
            Console.WriteLine("Array after sorting");
            Array.Sort(array4);
            for (int i = 0; i < array4.Length; i++)
            {
                Console.WriteLine(array4[i]);
            }
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
