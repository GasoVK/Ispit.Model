using System;
using System.Collections.Generic;
using Ispit.Model;

namespace Ispit.Konzola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> ucenici = new List<Ucenik>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"--- Unos podataka za {i}. učenika ---");
                Ucenik noviUcenik = new Ucenik();

                Console.Write("Ime: ");
                noviUcenik.Ime = Console.ReadLine();

                Console.Write("Prezime: ");
                noviUcenik.Prezime = Console.ReadLine();

                Console.Write("Datum rođenja (yyyy-mm-dd): ");
                noviUcenik.DatumRodjenja = DateTime.Parse(Console.ReadLine());

                Console.Write("Prosjek (npr. 4,5): ");
                noviUcenik.Prosjek = double.Parse(Console.ReadLine());

                ucenici.Add(noviUcenik);
                Console.WriteLine();
            }

            Console.WriteLine("\n================ ISPIS UČENIKA ================");
            foreach (var u in ucenici)
            {
                Console.WriteLine($"Učenik: {u.Ime} {u.Prezime}");
                Console.WriteLine($"Starost: {u.Starost()} godina");
                Console.WriteLine($"Prosjek: {u.Prosjek} ({u.IspisProsjeka()})");
                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("Pritisnite bilo koju tipku za kraj...");
            Console.ReadKey();
        }
    }
}
