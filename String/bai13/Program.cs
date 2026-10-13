using System;
class Program
{
    static void Main()
    {
        Console.Write("s = ");
        String s = Console.ReadLine() ?? "";

        Console.Write("sub = ");
        String sub = Console.ReadLine() ?? "";

        String[] words = s.Split(' ');

        int dem = 0;
        for(int i = 0; i < words.Length; i++)
        {
            if(words[i] == sub)
            {
                dem++;
            }
        }
        if(dem > 0)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }
    }
}