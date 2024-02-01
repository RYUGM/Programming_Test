using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_TEST_20240201_DoubleList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] temp = new int[5, 2];

            Console.WriteLine(temp.GetLength(1)+"");


        }

        static int[] solution(int[] array, int[,] commands)
        {

            int cnt = 0;
            string result_temp = "";
            string result = "";
            for (int i = 0; i < commands.GetLength(0); i++)
            {

                for (int j = 0; j < commands.GetLength(1); j++)
                {
                    cnt++;

                    if (commands.GetLength(1) == cnt)
                    {
                        /*
                       1. [x,y,z] 에서 x~y 사이 -> Sort 정렬 -> z번째 값
                       */
                        int x = commands[i, j - 2];
                        int y = commands[i, j - 1];
                        int z = commands[i, j];
                        if (z == 1)
                        {
                            //   z= 0;
                        }

                        int[] result_int_temp = new int[y];

                        int count = 0;
                        for (int t = x - 1; t < y; t++)
                        {
                            result_temp += array[t] + " ";

                            count++;
                        }
                        result_temp = result_temp.Substring(0, result_temp.Length - 1);
                        Console.WriteLine(result_temp + "/");
                        string[] temp_array = result_temp.Split(' ');

                        int[] temp_iint = new int[temp_array.Length];
                        for (int p = 0; p < temp_iint.Length; p++)
                        {
                            temp_iint[p] = int.Parse(temp_array[p]);
                        }

                        Array.Sort(temp_iint);
                        Console.WriteLine(temp_iint[z - 1] + "?");




                        result += temp_iint[z - 1] + " ";

                        result_temp = "";
                        cnt = 0;
                        count = 0;
                    }


                }



            }

            /*
               int [] answer= new int [answer_temp.Length];
            for(int i = 0; i<answer_temp.Length; i++){
                answer[i] = int.Parse(answer_temp[i]);

            }
            */
            string[] answer_temp = result.Split(' ');
            Console.WriteLine("");
            int[] answer = new int[answer_temp.Length - 1];

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = int.Parse(answer_temp[i]);
            }


            return answer;
        }
    }
}
