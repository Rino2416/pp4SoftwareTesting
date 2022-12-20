using System;
using System.Diagnostics.CodeAnalysis;

namespace WorkWithMatrixLib
{
    public class MyMatrix
    {
        public int GetMaxRow(int[,] matrix)
        {
            int a = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                if (a < sum)
                {
                    a = sum;
                }
            }
            return a;


        }
        public int GetNotEven(int[,] matrix)
        {
            int countOfNotEven = 0;

            int a = 0, b = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                if (a < sum)
                {
                    a = sum;
                    b = i;
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                    if (matrix[b,i] % 2 != 0) 
                    { 
                        countOfNotEven++; 
                    }
                
            }
            return countOfNotEven;
        }

        public int GetNegative(int[,] matrix)
        {
            int countOfNegative = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        countOfNegative++;
                    }
                }

            }
            return countOfNegative;
        }

        public int SumOfElements(int[,] matrix) 
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
 
                        sum += matrix[i, j];
        
               }
            }
            return sum;
        }

        public int CheckMatrixZero(int[,] matrix)
        {
            int countZero = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        countZero++;
                    }
                }
            }
            return countZero;
        }
    }
}
