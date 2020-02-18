using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biliárd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int leeső = LeesőSorsoló(golyók);
            Kiíró(golyók);           

            Console.ReadKey();
        }

        static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.WriteLine($"{item} ");
            }
        }

        static int LeesőSorsoló(List<int> golyók)
        {
            Random rnd = new Random();
            int szám;
            szám = rnd.Next(golyók.Count);
            golyók.Remove(szám);
            return golyók[szám];
        }

        static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i < 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
