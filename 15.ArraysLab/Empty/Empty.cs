namespace Empty
{
    using System;

    public class Empty
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var array = new int[n];
            var reversed = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }

            PrintArray(reversed);
        }

        public static void PrintArray(int[] reversed)
        {
            for (int i = 0; i < reversed.Length; i++)
            {
                if (i == reversed.Length - 1)
                {
                    Console.WriteLine(reversed[i]);
                    return;
                }

                Console.Write(reversed[i] + " ");
            }
        }
    }
}
