using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
        }

      

public class Solution
    {
        public bool solution(string s)
        {


            int cnt = 0;
            foreach (char word in s)
            {
                // '('일 경우 스택에 push
                if (word == '(')
                {
                    cnt++;
                    continue;
                }

                // ')' 문자 면서 스택에 남아있는 요소가 없을 경우 false
                if (cnt == 0)
                {
                    return false;
                }

                // 스택에 남아있는 요소가 있다면 pop
                cnt--;
            }

            // 스택에 남아있는게 없이 딱 맞아 떨어질 경우 true 반환
            return cnt == 0;
        }
    }
}
}
