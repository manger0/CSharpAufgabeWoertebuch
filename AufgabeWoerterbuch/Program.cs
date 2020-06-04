using System;
using System.Collections.Generic;

namespace AufgabeWoerterbuch
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            bool run = true;

            do
            {
                Console.WriteLine("\n1) Wort eintragen");
                Console.WriteLine("2) Wort suchen");
                Console.WriteLine("3) exit \n");
                string UserTask = Console.ReadLine();

                switch (UserTask)
                {
                    case "1":
                        Console.WriteLine("Geben sie bitte das deutsche Wort ein");
                        string GermanWord = Console.ReadLine();
                        Console.WriteLine("Geben sie bitte das englische Wort ein");
                        string EnglischWord = Console.ReadLine();
                        Dict.Add(GermanWord, EnglischWord);
                        break;

                    case "2":
                        Console.WriteLine("Geben sie bitte das deutsche Wort ein");
                        string GermanWordSearch = Console.ReadLine();
                        string Translation;
                        if (Dict.TryGetValue(GermanWordSearch, out Translation))
                        {
                            Console.WriteLine("Die englische Übersetzung " + GermanWordSearch);
                            Console.WriteLine(Translation);
                        } else
                        {
                            Console.WriteLine("Wort konnte nicht gefunden werden");
                        }
                        break;

                    case "3":
                        run = false;
                        break;
                }

            } while (run);
        }     
    }
}
