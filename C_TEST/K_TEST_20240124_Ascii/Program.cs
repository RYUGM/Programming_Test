using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_TEST_20240124_Ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp_s = "z";
            char temp_c = char.Parse (temp_s.Substring(0, 1));
            int temp_i = (int)temp_c;
            char temp_xx = (char)32;

            if (char.IsUpper((char)temp_i))
            {
                Console.WriteLine((char)temp_i + "B" + temp_i+"/" + (char)(64 + (94 - 90)));
            }
            else {
                Console.WriteLine((char)temp_i + "S"+ temp_i + "/" + (char)(96+((122+25)-122)));
            }

           

        }
        static string solution(string s, int n)
        {
            string answer = "";

            char temp = (char)32;
            int temp_int = 0;
            char[] char_array = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                temp = char.Parse(s.Substring(i, 1));
                temp_int = (int)temp;
                if (temp_int == 32)
                { //공백
                    char_array[i] = (char)temp_int;
                }
                else if (char.IsUpper(temp))
                {
                    //대문자일때
                    if (temp_int + n > 90)
                    {
                        temp_int = (64 + ((temp_int + n) - 90));
                        char_array[i] = (char)temp_int;
                        //A = 65 + 90/temp_int+n

                    }
                    else
                    {
                        temp_int = temp_int + n;
                        char_array[i] = (char)temp_int;
                    }


                }
                else if (char.IsLower(temp))
                {
                    //소문자일때
                    if (temp_int + n > 122)
                    {
                        //a = 97
                        temp_int = (96 + ((temp_int + n) - 122));
                        char_array[i] = (char)temp_int;
                    }
                    else
                    {
                        temp_int = temp_int + n;
                        char_array[i] = (char)temp_int;
                    }



                }

            }

            string result_string = "";
            for (int i = 0; i < char_array.Length; i++)
            {


                result_string += char_array[i].ToString();
            }


            return result_string;
        }
    }
}
