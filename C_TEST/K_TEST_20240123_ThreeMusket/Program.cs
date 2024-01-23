using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_TEST_20240123_ThreeMusket
{
    class Program
    {
        static void Main(string[] args)
        {
          

        }
        static int solution(int[] number)
        {
            int answer = 0;

            int temp_value = 0;
            for (int i = 0; i < number.Length; i++)
            {

                for (int j = i + 1; j < number.Length; j++)
                {


                    for (int n = j + 1; n < number.Length; n++)

                        if ((number[i] + number[j] + number[n]) == 0)
                        {
                            // temp_value = number[i]+number[j]+number[n];

                            answer++;

                        }

                }

            }


            return answer;
        }
    }
}
