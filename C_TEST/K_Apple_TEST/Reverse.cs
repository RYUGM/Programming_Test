using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Apple_TEST
{
    
public class Solution
    {
        /*
         함수 solution은 정수 n을 매개변수로 입력받습니다. n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요. 예를들어 n이 118372면 873211을 리턴하면 됩니다.
             */
        public long solution(long n)
        {

            int n_cnt = n.ToString().Length;
            int[] n_cnt_array = new int[n_cnt];
            for (int i = 0; i < n_cnt; i++)
            {
                n_cnt_array[i] = int.Parse(n.ToString().Substring(i, 1));

            }
            Array.Sort(n_cnt_array);
            Array.Reverse(n_cnt_array);
            long answer = 0;
            string temp_string = "";
            for (int i = 0; i < n_cnt_array.Length; i++)
            {
                temp_string += n_cnt_array[i].ToString();
            }

            answer = long.Parse(temp_string);
            return answer;
        }
    }
}
