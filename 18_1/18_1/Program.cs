using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, m];
            int[] otv = new int[n];
            for(int i=0;i<n;i++)
            {
                otv[i] = 1;
            }
            for (int i=0; i<n;i++)
            {
                for (int j=0; j<m;j++)
                {
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    otv[i] = otv[i] * mas[i,j];
                }
            }
            for (int i=0;i<n;i++)
            {
                Console.Write(otv[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
//Чайкин Степан Станиславович, ИСиП-21
