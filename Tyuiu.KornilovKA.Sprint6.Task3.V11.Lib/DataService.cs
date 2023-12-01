using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KornilovKA.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    if(matrix[j, 0] < matrix[i, 0])
                    {
                        int temp = matrix[i, 0];
                        matrix[i, 0] = matrix[j, 0];
                        matrix[j, 0] = temp;
                    }
                }
            }
            return matrix;
        }
    }
}
