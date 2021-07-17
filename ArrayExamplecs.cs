using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccess.Array
{
    class ArrayExamplecs
    {
        public void SimpleIntegerArray()
        {
            int [] arr = new int[5];
            Console.WriteLine("Enter Elements in array");
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void MatrixMultiplication()
        {
            int r1 = 2, c1 = 2, r2 = 2, c2 = 2;
            int[,] arrFirst = { { 7, 8, 9 }, { 9, 4, 1 } };
            int[,] arrSecond= { { 5, 6, 8 }, { 6, 7, 4 } };
            Console.WriteLine(" First Matrix ");
            for (int i = 0; i < r1; i++) {
                for (int j = 0; j < r2; j++) {
                    Console.Write(arrFirst[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" Second Matrix ");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(arrSecond[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] c = new int[r1, c2];
            for (int i = 0; i < r1; i++)
            {
                for(int j=0;j<c2; j++)
                {
                    c[i, j] = 0;
                    for(int k=0;k<c1; k++)
                    {
                        c[i, j] += arrFirst[i, k] * arrSecond[k, j]; 
                    }
                }
            }


            Console.WriteLine("Your Answer Is : ");
            for(int i=0;i<r1; i++)
            {
                for(int j=0;j<c1; j++)
                {
                    Console.Write(c[i, j] + " \t");
                }
                Console.WriteLine();
            }
          
        }
        public void MatrixAddition()
        {
            int r1 = 3, c1 = 3, r2 = 3, c2 = 3;
            int[,] arrFirst = { { 7, 8, 9 }, { 9, 4, 1 }, { 7, 9, 5 } };
            int[,] arrSecond = { { 5, 6, 8 }, { 6, 7, 4 }, { 4, 1, 8 } };
            Console.WriteLine(" First Matrix ");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < r2; j++)
                {
                    Console.Write(arrFirst[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" Second Matrix ");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(arrSecond[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] arrayOp = new int[r1, c1];
            for(int i=0;i<r1;i++)
            {
                for(int j=0;j<c1;j++)
                {
                    arrayOp[i, j] = arrFirst[i, j] + arrSecond[i, j];
                }
            }
            Console.WriteLine("Output is : ");
                for (int i = 0; i < r1; i++) { 
                for(int j = 0; j < c1; j++)
                {
                    Console.Write(arrayOp[i, j] + " \t ");
                }
                Console.WriteLine();
            }
        }
    }
}
