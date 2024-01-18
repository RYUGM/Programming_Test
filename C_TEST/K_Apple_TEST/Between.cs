using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Apple_TEST
{
    public class Solution_Between
    {
        /*
         두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수, solution을 완성하세요.
예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 리턴합니다.
             */
        public long solution(int a, int b)
        {
            long answer = 0;

            while (true)
            {
                if (a == b)
                {
                    answer = a;
                    break;
                }
                else if (a > b)
                {
                    answer += b;
                    b++;
                    if (a == b)
                    {
                        answer += b;
                        break;
                    }
                }
                else if (a < b)
                {
                    answer += a;
                    a++;
                    if (a == b)
                    {
                        answer += a;
                        break;
                    }
                }

            }

            return answer;
        }
    }

}
