using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int line_cnt = int.Parse(Console.ReadLine());

        int cnt = 0;
        string temp_1 = "";
        string temp_2 = "";

        string resutl = "";
        temp_1 = Console.ReadLine();
        while (true)
        {


            if (cnt != 0)
            {
                temp_2 = Console.ReadLine();

                if (temp_1.Substring(temp_1.Length - 1, 1) == temp_2.Substring(0, 1))
                {
                    temp_1 = temp_2;
                    temp_2 = "";
                    resutl = "yes";
                }
                else if (temp_1.Substring(temp_1.Length - 1, 1) != temp_2.Substring(0, 1))
                {
                    resutl = temp_1.Substring(temp_1.Length - 1, 1) + " " + temp_2.Substring(0, 1);
                    break;
                }
            }




            cnt++;
            if (cnt == line_cnt)
            {
                resutl = "Yes";
                break;
            }

        }

        Console.WriteLine(resutl);

    }
}