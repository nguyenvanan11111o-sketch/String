using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine()?? "";

        String[] words = s.Split(' ');
        Console.Write(words.Length);
    }
}
