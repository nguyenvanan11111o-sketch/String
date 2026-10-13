using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine() ?? "";

        Console.Write("Nhap chuoi 2: ");
        String a = Console.ReadLine() ?? "";

        if(a == s)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
