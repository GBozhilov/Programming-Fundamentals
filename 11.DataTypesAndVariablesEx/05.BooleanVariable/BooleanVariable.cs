using System;

public class BooleanVariable
{
    public static void Main()
    {
        while (true)
        {
            var text = Console.ReadLine().ToLower();

            if (text == "true" || text == "false")
            {
                var boolVal = Convert.ToBoolean(text);

                Console.WriteLine(boolVal ? "Yes" : "No");

                break;
            }
        }
    }
}