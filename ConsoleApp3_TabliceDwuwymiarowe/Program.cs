using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_TabliceDwuwymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[3,2];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Tablica dwuwymiarowa: ");

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tablica tablicy: ");
                int[][] tab2 = new int[2][];
            tab2[0] = new int[1];
            tab2[1] = new int[4];
            for (int i = 0; i < tab2.Length; i++)
            {
                for (int j = 0; j < tab2[i].Length; j++)
                {
                    tab2[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Tablica tablicy po wprowadzeniu liczb: ");
            for (int i = 0; i < tab2.Length; i++)
            {
                for (int j = 0; j < tab2[i].Length; j++)
                {
                   Console.Write(tab2[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
