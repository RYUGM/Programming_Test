using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{

    internal class Program
    {


        static void Main(string[] args)
        {
            int[] num = { 2, 1, 3, 4, 1 };
          //  solution(num);

            solution(3,1,20);
        }

        static string solution(int[] numbers)
        {

            string temp = "";
            string temp_2 = "";
            string result = "";
          
            for (int i = 0; i < numbers.Length; ++i)
            {

                for (int j = i + 1; j < numbers.Length; ++j)
                {

                    temp += (numbers[i] + numbers[j]) +" ";
                    temp_2 = (numbers[i] + numbers[j])+"";
                    string[] result_temp = temp.Split(' ');
                  
                  

            }
               
            }
            Console.WriteLine(temp);
            string[] result_temp_2 = temp.Split(' ');

            Array.Sort(result_temp_2);

            string temp_r = result_temp_2[0];
            string temp_result ="";

           
            for (int i = 1; i < result_temp_2.Length-1; i++) {
               
                if (temp_r == result_temp_2[i]) {

                }
                else
                {
                    temp_result += result_temp_2[i] +" ";
                    temp_r = result_temp_2[i];
                }
              

               
               
            }

            temp_result += result_temp_2[result_temp_2.Length - 1];
            string[] result_an = temp_result.Split(' ');
            int[] result_answer = new int[result_an.Length];
            for (int i = 0; i < result_an.Length; i++) {
                result_answer[i] = int.Parse(result_an[i]); 
            }
           
           

            return result_an[0];
        }



        static int solution(int a, int b, int n)
        {
            //a = 빈병 단위 , b = 빈병 교환 갯수 , n = 빈병 전체 갯수
            int answer = n;
            int result = 0;
            while (true)
            {
                result += (answer / a);
                answer = (answer - ((answer / a) * a)) + (answer / a);
             
              
              
                if ((answer / a) == 1 )
                {
                    result += (answer / a);
                    answer = (answer - ((answer / a) * a)) + (answer / a);

                  

                    break;
                }
                else if ((answer / a) == 0)
                {
                    result += result + b;



                    break;
                }
            }

            Console.WriteLine(result);


            return result;
        }
    }  
    
}
