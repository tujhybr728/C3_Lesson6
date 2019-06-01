using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace С3_Lesson6
{
    class Program
    {
        private static int round = 4; //кол-во потоков для работы над массивом
        private static int maxpull = 100; //размерность матрицы
        static Random rnd = new Random();
        //int[,] d;
        
        internal static class Paralel
        {


        }

        private static void Randomizer_Matrix(int [,] d)
        {            
            for (int i = 0; i < maxpull; i++)
                for (int j = 0; j < maxpull; j++)
                    d[i, j] = rnd.Next(10);
        }
        static void Main()
        {
            int[,] A = new int[maxpull, maxpull];
            int[,] B = new int[maxpull, maxpull];
            int[,] C = new int[maxpull, maxpull];
            Randomizer_Matrix(A);
            Randomizer_Matrix(B);
            Parallel.For(0, maxpull, i => {

                for (int j = 0; j < maxpull; j++)

                {

                    for (int k = 0; k < maxpull; k++)

                    {

                        C[i, j] += A[i, k] * B[k, j];

                    }

                }

            });

            for (int i = 0; i < maxpull; i++)
                for (int j = 0; j < maxpull; j++)
                    if (j == maxpull-1) Console.WriteLine("{0} ", C[i, j]);
                    else Console.Write("{0} ", C[i, j]);

            Console.ReadLine();
        }

        static void ThreadMetod()
        {

        }
    }
}
