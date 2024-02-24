using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarRentalConsoleApp.backend
{
    public static class JsonDataReader
    {
        public static List<Klient> GetKlient()
        {
            var path = Directory.GetCurrentDirectory() + "..\\..\\..\\..\\klienci.json";
            var data = File.ReadAllText(path);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<List<Klient>>(data, options);
        }

        public static List<Samochod> GetSamochod()
        {
            string path = Directory.GetCurrentDirectory() + "..\\..\\..\\..\\samochody.json";
            var data = File.ReadAllText(path);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<List<Samochod>>(data, options);
        }
    }
}
