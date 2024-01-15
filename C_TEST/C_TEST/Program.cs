
using System;
using static Example;

public class Example
{
    //string split
 
    public static void Main()
    {

        int A= solution("asdaaa");
        Console.WriteLine(A+"");

    }

        static int solution(string s)
        {


            int num1 = 0;
            int num2 = 0;
            int result = 0;
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {

                if (num1 == num2)
                {
                    result++;
                    temp = s.Substring(i, 1);
                }

                if (temp == s.Substring(i, 1))
                {
                    num1++;
                }
                else
                {
                    num2++;
                }


            }


            int answer = result;
            return answer;
       
    }


}