
using System;
using static Example;

public class Example
{
    //최소 공약

    public static void Main()
    {

        Console.WriteLine(  "asdf");

    }

    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {

        /*
        numer1 1 numer2 3
        denom1 2 denom2 4
        
        */
        int top_num = (numer1 * denom2) + (numer2 * denom1);
        int bottom_num = (denom1 * denom2);

        int min = 0;

        for (int i = 1; i <= top_num; i++)
        {
            if (top_num % i == 0 && bottom_num % i == 0)
            {
                min = i;
            }

        }


        int[] answer = { (top_num / min), (bottom_num / min) };
        return answer;
    }


}