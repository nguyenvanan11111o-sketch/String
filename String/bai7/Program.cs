using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine() ?? "";

        bool check = true;
        for(int i = 0; i <= s.Length/2; i++)
        {
            if(s[i] != s[s.Length - 1 - i])
            {
                check = false;
                break;
            }
        }
        Console.WriteLine(check);
    }
}