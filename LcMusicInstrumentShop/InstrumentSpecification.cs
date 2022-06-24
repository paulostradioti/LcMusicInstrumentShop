using LcMusicInstrumentShop.Constants;
using LcMusicInstrumentShop.InstrumentProperties;
using System.Collections.Generic;

namespace LcMusicInstrumentShop
{
    public class InstrumentSpecification
    {
        public List<InstrumentProperty> Properties { get; set; }
        public InstrumentBuilder Builder { get; set; }
        public int MakeYear { get; set; }
    }
}