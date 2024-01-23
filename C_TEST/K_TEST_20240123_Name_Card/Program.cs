using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_TEST_20240123_Name_Card
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int solution(int[,] sizes)
        {

            int max_num = 0;
            int temp_num = 0;
            for (int i = 0; i < sizes.Length / 2; i++)
            {

                if (sizes[i, 0] < sizes[i, 1])
                {
                    temp_num = sizes[i, 1];
                }
                else
                {
                    temp_num = sizes[i, 0];
                }

                if (max_num < temp_num)
                {
                    max_num = temp_num;
                }
            }


            int min_num = 0;
            int temp_min = 0;
            for (int i = 0; i < (sizes.Length / 2); i++)
            {

                if (sizes[i, 0] < sizes[i, 1])
                {
                    temp_min = sizes[i, 0];
                }
                else
                {
                    temp_min = sizes[i, 1];
                }

                if (min_num < temp_min)
                {
                    min_num = temp_min;
                }
            }


            // max_num = sizes[3,1];

            return max_num * min_num;
        }
    }
}
