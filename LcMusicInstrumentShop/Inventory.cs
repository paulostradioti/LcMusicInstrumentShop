using LcMusicInstrumentShop.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LcMusicInstrumentShop
{
    internal class Inventory
    {
        private static string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
        private static List<Instrument> instruments = new List<Instrument>();

        public static int Count { get => instruments.Count; }

        private Inventory()
        {
        }

        public static void Save()
        {
            string jsonString = JsonSerializer.Serialize(instruments);
            File.WriteAllText(dbFile, jsonString);
        }

        public static void Load()
        {
            if (!File.Exists(dbFile))
            {
                instruments = new List<Instrument>() {
                    new Instrument(){ InstrumentType = InstrumentType.Guitar, Name = "Collings CJ 6-strings acustic", Price = 3999.95, SerialNumber = 11277},
                    new Instrument(){ InstrumentType = InstrumentType.Guitar, Name = "Fender stratocastor 6-strings eletric", Price = 1499.95, SerialNumber = 11277},
                };
                Save();
            }
            else
            {
                string jsonContent = File.ReadAllText(dbFile);
                instruments = JsonSerializer.Deserialize<List<Instrument>>(jsonContent);
            }
        }

        public static void Add(Instrument instrument)
        {
            instruments.Add(instrument);
            Save();
        }
    }
}
