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
            int[] result_array = solution("banana");

            string result = "";
            for (int i = 0; i < result_array.Length; i++) {
                result += result_array[i]+"";
            }
            string a = "asdbasdfas";
          
        }
        static int[] solution(string s)
        {
            int[] answer = new int[s.Length];

            int index = -1;
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                index = -1; //없으면 -1
                for (int j = i - 1; j >= 0; j--)
                {
                  
                    temp += s[i] + "["+(i-j)+"]" + s[j];
                    if (s[i] == s[j])
                    {
                        temp += " = " + s.Substring(i,1)  + s.Substring(j,1) +" = " + Environment.NewLine;
                        index = i - j; //있으면 i-j
                        temp += "break";
                        break;
                    }
                }
                Console.WriteLine(temp);
                answer[i] = index;
            }

            return answer;
        }
    }
}
