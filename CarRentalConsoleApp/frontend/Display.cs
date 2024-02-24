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
            Console.WriteLine("MENU GŁÓWNE");
            Console.WriteLine("1 -> LISTA KLIENTÓW I SAMOCHODÓW");
            Console.WriteLine("2 -> WYPOŻYCZENIE SAMOCHODU");
            Console.WriteLine("3 -> ZAKOŃCZ PROGRAM");
            Console.WriteLine();
            Console.WriteLine("Naciśnij 1, 2 lub 3 -> ...");
        }

        public static void DisplayKIS()
        {
            Console.WriteLine("Lista klientów:");
            //foreach (var Klient in ListaKlientow)
            //{
            //Console.WriteLine($"ID: {Klient.Id}, Imię i nazwisko: {Klient}");
            //}
        }
    }
}
