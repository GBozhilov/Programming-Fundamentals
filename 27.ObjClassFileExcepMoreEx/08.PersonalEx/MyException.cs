using System;

public class MyException
{
    public static void Main()
    {
        while (true)
        {
            var number = int.Parse(Console.ReadLine());

            try
            {
                if (number < 0)
                {
                    throw new PersonalException();
                }

                Console.WriteLine(number);
            }
            catch (PersonalException pe)
            {
                Console.WriteLine(pe.Message);
                return;
            }
        }
    }
}