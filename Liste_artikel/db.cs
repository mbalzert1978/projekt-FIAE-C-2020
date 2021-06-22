using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Liste
{
    class FahrzeugDB
    {
        protected List<Fahrzeug> Fahrzeuge { get; set; }
        public FahrzeugDB()
        {
            Fahrzeuge = new List<Fahrzeug>();// Geholfen von Martin Michel
        }
        public void DBFahrzeugHinzufügen()
        {
            string user_eingabe;
            Console.Write("Bitte geben Sie die Art des Fahrzeuges an(Auto/Bulldozer/Panzer): ");
            user_eingabe = Console.ReadLine().ToLower();
            switch (user_eingabe)
            {
                default:
                    Console.WriteLine("Bitte geben Sie einen der obengenannten Fahzeugtypen an:");
                    Console.WriteLine("Eingabe für weiter...");
                    Console.ReadKey();
                    break;
                case "auto":
                    Auto auto = new Auto();
                    Console.Write("Bitte geben Sie den Namen des Autos an: ");
                    auto.Name = Console.ReadLine();
                    if (IstNameVergeben(auto.Name))
                    {
                        Console.WriteLine("Auto berreits angelegt.");
                        Console.WriteLine("Weiter mit Enter..");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Bitte geben Sie den Hersteller an: ");
                        auto.Hersteller = Console.ReadLine();
                        Console.Write("Bitte geben Sie den Luftdruck an: ");
                        auto.Luftdruck = Console.ReadLine();
                        Fahrzeuge.Add(auto);
                    }
                    break;
                case "bulldozer":
                    Bulldozer bulldozer = new Bulldozer();
                    Console.Write("Bitte geben Sie den Namen des Bulldozers an: ");
                    bulldozer.Name = Console.ReadLine();
                    if (IstNameVergeben(bulldozer.Name))
                    {
                        Console.WriteLine("Bulldozer berreits angelegt.");
                        Console.WriteLine("Weiter mit Enter..");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Bitte geben Sie den Hersteller an: ");
                        bulldozer.Hersteller = Console.ReadLine();
                        Console.Write("Bitte geben Sie die Kettenlänge an: ");
                        bulldozer.Kettenlaenge = Console.ReadLine();
                        Fahrzeuge.Add(bulldozer);
                    }
                    break;
                case "panzer":
                    Panzer panzer = new Panzer();
                    Console.Write("Bitte geben Sie den Namen des Panzers an: ");
                    panzer.Name = Console.ReadLine();
                    if (IstNameVergeben(panzer.Name))
                    {
                        Console.WriteLine("Panzer berreits angelegt.");
                        Console.WriteLine("Weiter mit Enter..");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Bitte geben Sie den Hersteller an: ");
                        panzer.Hersteller = Console.ReadLine();
                        Console.Write("Bitte geben Sie die Kettenlänge an: ");
                        panzer.Kettenlaenge = Console.ReadLine();
                        Console.Write("Bitte geben Sie die Geschützeanzahl an: ");
                        panzer.AnzahlGeschuetze = Console.ReadLine();
                        Fahrzeuge.Add(panzer);
                    }
                    break;
            }
        }

        public bool IstDBLeer()
        {
            if (Fahrzeuge.Count() == 0)
            {
                Console.WriteLine("Keine Daten vorhanden");
                Console.ReadKey();
                return true;
            }
            return false;
        }
        public bool IstNameVergeben(string FahrzeugName)
        {
            foreach (Fahrzeug item in Fahrzeuge)
            {
                if (FahrzeugName == item.Name)
                {
                    return true;
                }

            }
            return false;
        }
        public void DBFahrzeugLöschen()
        {
            if (IstDBLeer())
                return;
            Console.Write("Bitte geben Sie den Fahrzeugnamen an: ");
            string user_eingabe = Console.ReadLine().ToLower();
            foreach (Fahrzeug item in Fahrzeuge)
            {
                if (user_eingabe == item.Name.ToLower())
                {
                    Fahrzeuge.Remove(item);
                    Console.WriteLine($"Fahrzeug mit dem Namen: {user_eingabe} erfolgreich gelöscht");
                    Console.ReadKey();
                    return;
                }
            }
        }
        public void DBFahrzeugÄndern()
        {
            if (IstDBLeer())
                return;
            Console.Write("Bitte geben Sie den Fahrzeugnamen an: ");
            string user_eingabe = Console.ReadLine();
            foreach (Fahrzeug item in Fahrzeuge)
            {
                if (user_eingabe == item.Name)
                {
                    Fahrzeuge.Remove(item);
                    DBFahrzeugHinzufügen();
                    return;
                }
            }
        }
        public void DBFahrzeugeAnzeigen()
        {
            if (IstDBLeer())
                return;
            Fahrzeuge.Sort(delegate (Fahrzeug x, Fahrzeug y)
            {   // Geholfen von Martin Michel
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });

            foreach (Fahrzeug item in Fahrzeuge)
            {
                item.AnzeigenVonFahrzeugen();
            }
        }
        public void DBFahrzeugAnzeigen(string FahrzeugName)
        {

            foreach (Fahrzeug item in Fahrzeuge)
            {
                if (FahrzeugName == item.Name)
                {
                    item.AnzeigenVonFahrzeugen();
                    break;
                }

            }
        }

        public void BeispielDatenErzeugen()
        {
            Auto auto = new Auto();
            auto.Name = "M5";
            if (IstNameVergeben(auto.Name))
            {
                Console.WriteLine("Auto berreits angelegt.");
                Console.WriteLine("Weiter mit Enter..");
                Console.ReadLine();
                return;
            }
            else
            {
                auto.Hersteller = "BMW";
                auto.Luftdruck = "2,5";
                Fahrzeuge.Add(auto);
            }
            Bulldozer bulldozer = new Bulldozer();
            bulldozer.Name = "Bully";
            if (IstNameVergeben(bulldozer.Name))
            {
                Console.WriteLine("Bulldozer berreits angelegt.");
                Console.WriteLine("Weiter mit Enter..");
                Console.ReadLine();
                return;
            }
            else
            {
                bulldozer.Hersteller = "Schneider";
                bulldozer.Kettenlaenge = "2,5m";
                Fahrzeuge.Add(bulldozer);
            }
            Panzer panzer = new Panzer();
            panzer.Name = "Leopard I";
            if (IstNameVergeben(panzer.Name))
            {
                Console.WriteLine("Panzer berreits angelegt.");
                Console.WriteLine("Weiter mit Enter..");
                Console.ReadLine();
                return;
            }
            else
            {
                panzer.Hersteller = "Deutschland";
                panzer.Kettenlaenge = "5,5m";
                panzer.AnzahlGeschuetze = "1";
                Fahrzeuge.Add(panzer);
            }
            return;
        }
    }
}

