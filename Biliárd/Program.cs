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
            int leeső;
            do
            {
                leeső = LeesőSorsoló(golyók);
                Kiíró(golyók);
                Console.WriteLine(leeső);
            } while (leeső!=8);
            if (leeső==8)
            {
                Console.WriteLine("Nyertél!");
            }
            else
            {
                Console.WriteLine("Vesztettél!");
            }

            Console.ReadKey();
        }

        static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.Write($"{item} ");
            }
        }

        static int LeesőSorsoló(List<int> golyók)
        {
            Random rnd = new Random();
            int szám;
            szám = rnd.Next(golyók.Count);
            golyók.Remove(golyók[szám]);
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
