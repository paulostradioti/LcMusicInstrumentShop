using LcMusicInstrumentShop.Constants;

namespace LcMusicInstrumentShop
{
    internal class Instrument
    {
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public double Price { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public InstrumentSpecification Specifications { get; set; }
    }
}