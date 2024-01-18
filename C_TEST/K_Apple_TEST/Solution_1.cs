using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Apple_TEST
{
    using System;
    public class Solution_1
    {
        /*
         자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요. 예를들어 n이 12345이면 [5,4,3,2,1]을 리턴합니다.
             */
        public int[] solution(long n)
        {
            string temp = n.ToString();
            int[] answer = new int[temp.Length];
            int cnt = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                answer[i] = int.Parse(temp.Substring(i, 1));

            }

            Array.Reverse(answer);
            return answer;
        }
    }
}
