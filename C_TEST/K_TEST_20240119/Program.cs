public class Solution
{
    public int solution(int num)
    {
        int answer = 0;

        int input_num = num;
        int result_num = 0;
        int cnt = 0;

        while (input_num != 1)
        {
            if (cnt >= 500) //int 범위 벗어나는 경우 있음...어이가 없네 ㅋㅋㅋ
            {
                return -1;
            }
            if (input_num % 2 == 0)
            {
                input_num = input_num / 2;

            }
            else
            {
                input_num = input_num * 3 + 1;
            }
            cnt++;

        }


        return cnt;
    }
}