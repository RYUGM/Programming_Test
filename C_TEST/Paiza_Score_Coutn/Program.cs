using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        int len = int.Parse(line);

        int cnt = 0;
        int q_cnt = 0;
        string temp_string = "";
        while (true)
        {
            string[] temp = Console.ReadLine().Split(' ');


            if (temp[0] != temp[1])
            {

                q_cnt++;
                temp_string += cnt + 1 + " ";

            }
            else if (temp[0] == "n" && temp[1] == "n")
            {

                q_cnt++;
                temp_string += cnt + 1 + " ";
            }
            else if (temp[0] == "y" && temp[1] == "y")
            {

            }



            cnt++;
            if (cnt == len)
            {
                break;
            }
        }
        temp_string += q_cnt + "";
        string[] temp_result = temp_string.Split(' ');

        Console.WriteLine(temp_result[temp_result.Length - 1]);
        for (int i = 0; i < temp_result.Length - 1; i++)
        {
            Console.WriteLine(temp_result[i]);
        }


    }
}

/*
4   
    3
y n  1
n y  2
n n 3
y y 0
*/