using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine() ?? "";

        int dem = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'a')
            {
                dem++;
            }
        }
        Console.Write(dem);
    }
}
