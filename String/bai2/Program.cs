using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap chuoi: ");
        String s = Console.ReadLine() ?? "";

        int dai = 0;
        for(int i = 0; i < s.Length; i++)
        {
            dai++;
        }
        Console.Write(dai);
    }
}