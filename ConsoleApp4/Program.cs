using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        static void Countzero()
        {
            int zeros = 0;
            int[] zero = new int[6] { 0, 1, 0, 1, 0, 1 };
            for (int i = 0; i < 6; i++)
            { if (zero[i] == 0) { zeros += 1; } }
            Console.WriteLine(zeros);
        }

        int[] add(int[] one, int[] two)
        {
            int[] three = new int[one.Length];
            for (int i = 0; i < one.Length; i++)
            {
                three[i] = one[i] + two[i];

            }
            return three;
        }

        string ToUpper()
        {   
            Console.WriteLine();
        }
    }
}
