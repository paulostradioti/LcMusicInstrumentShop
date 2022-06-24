using System;

namespace LcMusicInstrumentShop.InstrumentProperties
{
    public class InstrumentProperty
    {
        public string Name { get; set; }
        public object Value { get; set; }
        
        public InstrumentProperty(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}