using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        String s = Console.ReadLine()??"";

        int demso = 0;
        int demchu = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsLetter(s[i]))
            {
                demchu++;
            }
            else
            {
                demso++;
            }
        }
        Console.WriteLine("Chu cai: " + demchu);
        Console.WriteLine("Chu so: " + demso);
    }
}
