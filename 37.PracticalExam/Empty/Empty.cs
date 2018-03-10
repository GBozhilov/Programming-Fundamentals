using System;

public class Form
{
    public static void Main()
    {
        for (var row = 0; row < 9; row++)
        {
            for (var col = 0; col < 5; col++)
            {
                if (row == 0 || row == 4 || row == 8)
                {
                    Console.Write("1 ");
                }
                else if (row <= 3 && col == 0)
                {
                    Console.Write("1 ");
                }
                else if (row >= 5 && row <=7 && col == 4)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }

            Console.WriteLine();
        }
    }
}