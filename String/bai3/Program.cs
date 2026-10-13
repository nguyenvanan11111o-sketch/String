using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine() ?? "";

        for(int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i]);
        }
    }
}
