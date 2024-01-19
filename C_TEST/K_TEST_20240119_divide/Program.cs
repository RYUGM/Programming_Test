using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_TEST_20240119_divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] answer = new int[5] ;
            answer[0] = 5;
            string temp = "";
            int temp_int = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] % 1 == 0)
                {
                    temp += answer[i] + " ";
                    temp_int++;
                }
            }

            string[] temp_result = temp.Substring(0, temp.Length).Split(' ');
            int[] temp_result_int = new int[1];
            temp_result_int[0] = int.Parse(temp_result[0]);

            Console.WriteLine(temp_result_int[0]+"");

        }
    }
}
