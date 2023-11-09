using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class MusicalInstrument
    {
        private InstrumentInform instrumentInform;
        private int instrumentCount;

        public int InstrumentCount { get => instrumentCount; set => instrumentCount = value >= 0  ? value : throw new ArgumentOutOfRangeException(); }

        public MusicalInstrument(string instrumentType, string brand, string model, int yearManufactured, string color, int instrumentCount)
        {
            instrumentInform = new InstrumentInform( instrumentType,  brand,  model,  yearManufactured, color);
            InstrumentCount = instrumentCount;
        }
        public override string ToString()
        {
            return $"{instrumentInform.ToString()}, InstrumentCount: {InstrumentCount}";
        }
    }
}
