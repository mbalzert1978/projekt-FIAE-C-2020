using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Liste
{

    abstract class Fahrzeug
    {
        
        public string Name { get; set; }
        public string Hersteller { get; set; }
        virtual public void AnzeigenVonFahrzeugen()
        {
            Console.WriteLine("Kategorie: {0},  Fahrzeug Name: {1}, " +
                "Hersteller: {2}", nameof(Fahrzeug), Name,Hersteller);
        }
    }
    class Bulldozer : Fahrzeug
    {
        public string Kettenlaenge { get; set; }
        public override void AnzeigenVonFahrzeugen()
        {
            Console.WriteLine("Kategorie: {0}, Fahrzeug Name: {1}, " +
                "Hersteller: {2} Kettenlänge: {3}",
                nameof(Bulldozer), Name, Hersteller, Kettenlaenge);
        }
    }
    class Auto : Fahrzeug
    {
        public string Luftdruck { get; set; }
        public override void AnzeigenVonFahrzeugen()
        {
            Console.WriteLine("Kategorie: {0}, Fahrzeug Name: {1}, " +
                "Hersteller: {2}, Luftdruck: {3}",
                nameof(Auto), Name, Hersteller, Luftdruck);

        }
    }
    class Panzer : Bulldozer
    {
        public string AnzahlGeschuetze { get; set; }
        public override void AnzeigenVonFahrzeugen()
        {
            Console.WriteLine("Kategorie: {0}, Fahrzeug Name: {1}, " +
                "Hersteller: {2}, Kettenlänge: {3}, " +
                "Geschütz Anzahl: {4}", nameof(Panzer),
                Name, Hersteller, Kettenlaenge, AnzahlGeschuetze);

        }
    }
}
