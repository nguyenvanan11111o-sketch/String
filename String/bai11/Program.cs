using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine() ?? "";

        int max = 0;
        char kytu = ' ';

        for(int i = 0; i < s.Length; i++)
        {
            int dem = 0;
            for(int j = 0; j < s.Length; j++)
            {
                if(s[i] == s[j])
                {
                    dem++;
                }
            }
             if(dem > max)
            {
                max = dem;
                kytu = s[i];
            }
        }
        Console.WriteLine(kytu);
        Console.WriteLine(max);
    }
}
