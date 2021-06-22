using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            bool not_E = true;
            FahrzeugDB db = new FahrzeugDB();
            while (not_E)
            {
                Console.Clear();
                Console.WriteLine("DB - List (1.0)");
                Console.WriteLine("Bitte geben Sie an was Sie tun möchten:");
                Console.WriteLine("Alle Fahrzeuge anzeigen: A");
                Console.WriteLine("Ein Fahrzeug anzeigen:   M");
                Console.WriteLine("Hinzufügen:              H");
                Console.WriteLine("Beispieldaten erzeugen:  B");
                Console.WriteLine("Ändern:                  Ä");
                Console.WriteLine("Löschen:                 L");
                Console.WriteLine("Ende:                    E");
                string eingabe_user;
                eingabe_user = Console.ReadLine().ToLower();
                switch (eingabe_user)
                {
                    default:
                        Console.WriteLine("Bitte geben Sie einen der obengenannten Buchstaben an:");
                        Console.WriteLine("Eingabe für weiter...");
                        Console.ReadKey();
                        break;
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Anzeigen(sortiert nach Name) 'A'");
                        db.DBFahrzeugeAnzeigen();
                        Console.WriteLine("Eingabe für weiter...");
                        Console.ReadKey();
                        break;
                    case "b":
                        Console.Clear();
                        Console.WriteLine("BSP Daten 'B'");
                        db.BeispielDatenErzeugen();
                        Console.WriteLine("BSP Daten erzeugt. Eingabe für weiter...");
                        Console.ReadKey();
                        break;
                    case "m":
                        Console.Clear();
                        Console.WriteLine("Einzelanzeige 'M'");
                        if (db.IstDBLeer())
                            break;
                        Console.Write("Fahrzeugname: ");
                        eingabe_user = Console.ReadLine();
                        db.DBFahrzeugAnzeigen(eingabe_user);
                        Console.WriteLine("Eingabe für weiter...");
                        Console.ReadKey();
                        break;
                    case "h":
                        Console.Clear();
                        Console.WriteLine("Eingabe 'H'");
                        db.DBFahrzeugHinzufügen();
                        break;
                    case "ä":
                        Console.Clear();
                        Console.WriteLine("Ändern 'Ä'");
                        db.DBFahrzeugÄndern();
                        break;
                    case "l":
                        Console.Clear();
                        Console.WriteLine("Löschen 'L'");
                        db.DBFahrzeugLöschen();
                        break;
                    case "e":
                        not_E = false;
                        break;
                }
            }
        }
    }
}