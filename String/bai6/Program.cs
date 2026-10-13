using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine() ?? "";

        for(int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }
    }
}
