using LcMusicInstrumentShop.Constants;
using LcMusicInstrumentShop.InstrumentProperties;
using System;
using System.Collections.Generic;

namespace LcMusicInstrumentShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string xpto = Convert.ChangeType(pop, typeof(string));

            Inventory.Load();
            Console.WriteLine(Inventory.Count);

            var instrument = new Instrument()
            {
                InstrumentType = InstrumentType.Mandolin,
                Name = "Mandolin",
                Price = 1000,
                SerialNumber = 1234,
                Specifications = new InstrumentSpecification()
                {
                    Properties = new()
                    {
                        new InstrumentProperty("teste", "teste")
                    }
                }
            };

            Inventory.Add(instrument);
        }
    }
}
