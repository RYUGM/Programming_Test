using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_TEST_20240130_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = new string[] { "sun", "bed", "car" };

            for (int i = 0; i < solution(temp, 1).Length; i++) {
                Console.WriteLine(solution(temp, 1)[i]);
            }
           
        }

        static string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];
            int temp_int = n;

            for (int i = 0; i < strings.Length; i++)
            {
                answer[i] = strings[i].Substring(n, 1) + strings[i];

            }
            Array.Sort(answer);

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = answer[i].Substring(1, answer[i].Length - 1);
            }


            return answer;
        }
    }
}
