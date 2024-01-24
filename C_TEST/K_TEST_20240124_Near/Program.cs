using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_TEST_20240124_Near
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result_array = solution("aabbccddabc");

            string result = "";
            for (int i = 0; i < result_array.Length; i++) {
                result += result_array[i]+"";
            }

            Console.WriteLine(result);
        }
        static int[] solution(string s)
        {
            int[] answer = new int[s.Length];

            int index = -1;

            for (int i = 0; i < s.Length; i++)
            {
                index = -1; //없으면 -1
                for (int j = i - 1; j >= 0; j--)
                {
                    if (s[i] == s[j])
                    {
                        index = i - j; //있으면 i-j
                        break;
                    }
                }
                answer[i] = index;
            }

            return answer;
        }
    }
}
