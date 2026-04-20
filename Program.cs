using System;
using System.Collections.Generic;
using Ispit.Model1; // Ključna linija koja povezuje projekte

namespace Ispit.Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> ucenici = new List<Ucenik>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"--- Unos podataka za {i}. učenika ---");
                Ucenik u = new Ucenik();

                Console.Write("Ime: ");
                u.Ime = Console.ReadLine();

                Console.Write("Prezime: ");
                u.Prezime = Console.ReadLine();

                Console.Write("Datum rođenja (npr. 2005-05-15): ");
                u.DatumRodjenja = DateTime.Parse(Console.ReadLine());

                Console.Write("Prosjek (npr. 4,5): ");
                u.Prosjek = double.Parse(Console.ReadLine());

                ucenici.Add(u);
                Console.WriteLine();
            }

            Console.WriteLine("\n======= REZULTATI =======");
            foreach (var u in ucenici)
            {
                Console.WriteLine($"Učenik: {u.Ime} {u.Prezime}");
                Console.WriteLine($"Starost: {u.Starost()} god.");
                Console.WriteLine($"Uspjeh: {u.IspisProsjeka()}");
                Console.WriteLine("-------------------------");
            }
            Console.ReadKey();
        }
    }
}
