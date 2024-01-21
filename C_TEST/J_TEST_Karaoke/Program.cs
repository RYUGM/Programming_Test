using System;
class J_TEST_Karaoke
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = Console.ReadLine();
        string line_txt = line;
        string[] line_array = line_txt.Split(' ');

        int singer_cnt = int.Parse(line_array[0]);
        int song_length = int.Parse(line_array[1]);

        int[] singer_array = new int[singer_cnt];


        int song_length_cnt = 0;
        int[] default_scroe = new int[song_length];

        int compare_cnt = 0;
        int[] compare_score = new int[singer_cnt];

        int temp_result = 0;
        int input_result = 0;
        int user_cont = 0;
        while (true)
        {
            var line_num = Console.ReadLine();
            if (line_num == null)
            {

                //  Console.WriteLine("END");
                break;
            }

            int input_num = int.Parse(line_num);
            // Console.WriteLine( input_num+"input_num");
            if (song_length_cnt < song_length)
            {


                default_scroe[song_length_cnt] = input_num;
                //  Console.WriteLine(default_scroe[song_length_cnt]);
                song_length_cnt++;

            }

            else
            {
                song_length_cnt = song_length + song_length_cnt;


                if (compare_cnt < song_length)
                {
                    temp_result = Math.Abs(default_scroe[compare_cnt] - input_num);

                    if (temp_result > 5 && temp_result < 11)
                    {
                        input_result += -1;
                    }
                    else if (temp_result > 10 && temp_result < 21)
                    {
                        input_result += -2;
                    }
                    else if (temp_result > 20 && temp_result < 31)
                    {
                        input_result += -3;
                    }
                    else if (temp_result > 30)
                    {
                        input_result += -5;
                    }

                    compare_cnt++;
                    if (compare_cnt == song_length)
                    {


                        compare_score[user_cont] = input_result;
                        // Console.WriteLine( compare_score[user_cont]+"compare_cnt");
                        input_result = 0;
                        compare_cnt = 0;
                        user_cont++;

                    }

                }





            }








        }




        Array.Sort(compare_score);
        Array.Reverse(compare_score);

        int final_result = 100 + compare_score[0];







        if (final_result < 0 || final_result == 100)
        {
            final_result = 0;
        }
        Console.WriteLine(final_result);


    }
}

/*
2 3
400
410
420
400
400
400
300
300
300
出力例1
97
・誤差 5 Hz 以内なら減点しない
・上記に当てはまらず、誤差 10 Hz 以内なら 1 点減点
・上記に当てはまらず、誤差 20 Hz 以内なら 2 点減点
・上記に当てはまらず、誤差 30 Hz 以内なら 3 点減点
・上記に当てはまらない場合、5 点減点
*/