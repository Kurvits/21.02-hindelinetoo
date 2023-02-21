using System;
using System.Collections.Generic;

namespace _21._02_hindelineyoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> schools = new Dictionary<int, string>();
            schools.Add(1, "Tallinna Tööstushariduskeskus");
            schools.Add(2, "Kadrioru Saksa Gümnaasium");
            schools.Add(3, "Viimsi kool");

            foreach (KeyValuePair<int, string> school in schools)
            {
                Console.WriteLine("Kooli nimi: {1}", school.Key, school.Value);
            }

            Console.ReadKey();
        }
    }
}
