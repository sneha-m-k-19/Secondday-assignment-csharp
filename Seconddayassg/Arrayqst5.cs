using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add diagonal elements in the 2d array
namespace Seconddayassg
{
    class Arrayqst5
    {
        static void Main(string[] args)
        {
            int[,] array5 = new int[3,3] {{ 2, 3,4 },{5,6,7},{ 8, 9, 10 } };
            Console.WriteLine("Diagonal elements in Array 5 :");
            for (int i = 0; i <3; i++)
            {
                for (int j=0;j<3;j++)
                {
                    if(i==j)
                    {
                        Console.WriteLine(array5[i, j]);
                    }
                }
            }
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
        
    }
}
