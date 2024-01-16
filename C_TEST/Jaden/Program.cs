using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("asd");

        }
        public class Solution
        {
            public string solution(string s)
            {
                string temp = s.ToLower();

                bool chek = true;
                string temp_txt = "";
                for (int i = 0; i < temp.Length; i++)
                {
                    if (int.TryParse(temp.Substring(i, 1), out int x) != true && chek == true)
                    {
                        temp_txt += temp.Substring(i, 1).ToUpper();
                        chek = false;
                    }
                    else if (int.TryParse(temp.Substring(i, 1), out int y) == true && chek == true)
                    {
                        temp_txt += temp.Substring(i, 1);
                        chek = false;
                    }
                    else
                    {
                        temp_txt += temp.Substring(i, 1);
                    }

                    if (temp.Substring(i, 1) == " ")
                    {

                        chek = true;
                    }

                }

                string answer = temp_txt;
                return answer;
            }
        }
    }
}
