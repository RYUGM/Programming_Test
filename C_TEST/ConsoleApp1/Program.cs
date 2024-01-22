using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(1, 2);
        }
        static int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            int min = 1;
            int max = m;
            while (true)
            {
                if (max % m == 0 && max % n == 0)
                {
                    break;
                }
                max++;

            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    min = i;


                }

            }

            answer[0] = min;
            answer[1] = max;

            return answer;
        }
    }
}
