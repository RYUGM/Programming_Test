using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        public class Solution
        {
            public string solution(string s)
            {


                string[] temp_string = s.Split(' ');
                int[] temp_int = new int[temp_string.Length];

                for (int i = 0; i < temp_int.Length; i++)
                {
                    temp_int[i] = int.Parse(temp_string[i]);
                }




                string answer = "";
                int max_num = int.MinValue;
                int min_num = int.MaxValue;
                int temp_num = 0;

                foreach (var n in temp_int)
                {
                    if (n > max_num)
                    {
                        max_num = n;
                    }
                    if (n < min_num)
                    {
                        min_num = n;
                    }

                }

                answer = min_num + " " + max_num;

                return answer;
            }
        }
    }
}
