using System;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public int Starost()
        {
            DateTime danas = DateTime.Now;
            int godine = danas.Year - DatumRodjenja.Year;
            if (danas < DatumRodjenja.AddYears(godine)) godine--;
            return godine;
        }

        public string IspisProsjeka()
        {
            if (Prosjek >= 1 && Prosjek < 1.50) return "nedovoljan";
            if (Prosjek >= 1.50 && Prosjek < 2.50) return "dovoljan";
            if (Prosjek >= 2.50 && Prosjek < 3.50) return "dobar";
            if (Prosjek >= 3.50 && Prosjek < 4.50) return "vrlo dobar";
            if (Prosjek >= 4.50 && Prosjek <= 5) return "odličan";
            return "nevaljan prosjek";
        }
    }
}
