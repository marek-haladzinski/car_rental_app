using CarRentalConsoleApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalConsoleApp.frontend
{
    public static class Display
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("MENU GŁÓWNE");
            Console.WriteLine("1 -> LISTA KLIENTÓW I SAMOCHODÓW");
            Console.WriteLine("2 -> WYPOŻYCZENIE SAMOCHODU");
            Console.WriteLine("3 -> ZAKOŃCZ PROGRAM");
            Console.WriteLine();
            Console.WriteLine("Naciśnij 1, 2 lub 3 -> ...");
        }

        public static void DisplayK()
        {

            List<Klient> listaKlientow = JsonDataReader.GetKlient();

            Console.WriteLine("Lista klientów:");
            foreach (var Klient in listaKlientow)
            {
                Console.WriteLine($"ID: {Klient.Id}, Imię i nazwisko: {Klient.Name}");
            }
        }

        public static void DisplayS()
        {
            List<Samochod> listaSamochodow = JsonDataReader.GetSamochod();

            Console.WriteLine("Lista samochodów:");
            foreach(var Samochod in listaSamochodow)
            {
                Console.WriteLine($"ID: {Samochod.Id}, Marka i model: {Samochod.Marka}, Cena za dobę: {Samochod.Price} PLN");
            }
        }
    }
}
