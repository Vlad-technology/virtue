using System;

class Program
{
    static void Main()
    {
        var art = "           _,; ;.,_\r\n\r\n,-; ;,_;,',,,'''@\r\n  ,; ;``  `'\\\\|//``-:;,.\r\n@`         ; ^^^;      `'@\r\n           :@ @:\r\n           \\ u /\r\n  ,=,------)^^^(------,=,\r\n  '-'---- -/=====\\-----'-'\r\n          \\_____ /\r\n      '`\\ /_____\\\r\n      `\\ \\\\_____ / _\r\n        \\//_____\\/|\r\n        |        ||\r\n        | ldb | '\r\n        :________:`";
        Console.WriteLine(art);
        string[] name = ["", "one", "ten", "hundred", "thousand", "ten thousand", "hundred thousand"];
        var user_input = "0";
        while(true)
        {
            user_input = Console.ReadLine();
            var user_input_pallyndrom = Pallyndrom(user_input);
            if(user_input_pallyndrom.Length % 3 == 0)
            {
                var count = 0;
                var count_another = 0;
                string[] razd = new string[user_input_pallyndrom.Length / 3];
                for(int i = 0; i < user_input_pallyndrom.Length / 3; i++)
                {
                    razd[count] = user_input_pallyndrom.Substring(count_another, 3);
                    count++;
                    count_another = count_another + 3;
                }
                for(int i1 = 0; i1 < razd.Length; i1++)
                {
                    Console.Write(Pallyndrom(razd[razd.Length - i1 - 1]));
                    if (i1 == razd.Length - 1)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine("");
                //Console.WriteLine(string.Join(", ", razd));
                Console.WriteLine("Total digits: " + razd.Length.ToString());

            }
        }
    }
    static string Pallyndrom(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
