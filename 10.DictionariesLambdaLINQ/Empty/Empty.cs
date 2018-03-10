using System;
using System.Collections.Generic;

public class Empty
{
    public static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        phonebook["Pesho"] = "+0-155-7976";
        phonebook["John Smith"] = "+1-555-8976";
        phonebook["Lisa Smith"] = "+1-555-1234";
        phonebook["Sam Doe"] = "+1-555-5030";
        phonebook["Nakov"] = "+359-899-555-592";
        phonebook["Nakov"] = "+359-2-981-9819";

        phonebook.Remove("Pesho");
        phonebook.Remove("John Smith");

        foreach (KeyValuePair<string, string> pair in phonebook)
            Console.WriteLine($"{pair.Key} --> {pair.Value}");
    }
}