using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Comment
{
    public static string commentText = " ";
    public static void print()
    {
        line();
        Console.WriteLine();
        comment();
        Console.WriteLine();
    }
    static void line()
    {
        for(int i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("_");
        }
        Console.WriteLine();
    }
    static void comment()
    {
        for (int i = 0; i < Console.WindowWidth/2 - commentText.Length / 2; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(commentText);
    }
}
