using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            // 입력된 2차원 배열의 길이와 동일하게 설정
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            // 각각 더해준다.
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return answer;
        }
    }
}
