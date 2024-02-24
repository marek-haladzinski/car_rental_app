using CarRentalConsoleApp.frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarRentalConsoleApp.backend
{
    public class Rent
    {
        public static void CarRent()
        {
            Display.DisplayK();
            Console.WriteLine("");
            Console.WriteLine("Wybierz klienta do obsługi:");

            List<Klient> listaKlientow = JsonDataReader.GetKlient();
            List<Samochod> listaSamochodow = JsonDataReader.GetSamochod();

            int idKlienta;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out idKlienta) && listaKlientow.Exists(k => k.Id == idKlienta))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór klienta. Spróbuj ponownie.");
                }
            }

            Klient wybranyKlient = listaKlientow.Find(k => k.Id == idKlienta);

            Console.WriteLine($"Wybrany klient: {wybranyKlient.Name}");

            Console.WriteLine("--------------");
            Display.DisplayS();
            Console.WriteLine("--------------");
            Console.WriteLine("Wybierz samochód do wypożyczenia:");

            int idSamochodu;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out idSamochodu) && listaSamochodow.Exists(s => s.Id == idSamochodu))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór samochodu. Spróbuj ponownie.");
                }
            }

            Samochod wybranySamochod = listaSamochodow.Find(s => s.Id == idSamochodu);

            Console.WriteLine($"Wybrany samochód: {wybranySamochod.Marka}");

            Console.WriteLine("Podaj okres wypożyczenia (ilość dni): ");
            int okresWypozyczenia;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out okresWypozyczenia) && okresWypozyczenia > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy okres wypożyczenia. Spróbuj ponownie.");
                }
            }

            if(okresWypozyczenia != null)
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Wypożycznie zrealizowane!");
                Console.WriteLine($"Wybrany klient: {wybranyKlient.Name}");
                Console.WriteLine($"Wybrany samochód: {wybranySamochod.Marka}");
                Console.WriteLine($"Data wypożyczenia: {DateTime.Now.ToShortDateString()}");
                Console.WriteLine($"Data zwrotu pojazdu: {DateTime.Now.AddDays(okresWypozyczenia).ToShortDateString()}");
                Console.WriteLine($"Całkowita cena za wypożyczenie: {okresWypozyczenia * wybranySamochod.Price} PLN");

            }
            else
            {
                Console.WriteLine("Nieprawidłowy okres wypożyczenia. Spróbuj ponownie.");
            }
        }

    }
}
