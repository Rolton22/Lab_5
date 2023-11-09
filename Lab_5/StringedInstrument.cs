using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class StringedInstrument : MusicalInstrument
    {
        public static readonly int MAX_STRINGS = 12;
        public static readonly int MAX_FRETS = 24;
        public static readonly int MAX_TUNING_PEGS = 12;

        private int strings;
        private int frets;
        private int tuningPegs;

        public int Strings { get => strings; set => strings = value >= 0 && value <= MAX_STRINGS ? value : throw new ArgumentOutOfRangeException(); }
        public int Frets { get => frets; set => frets = value >= 0 && value <= MAX_FRETS ? value : throw new ArgumentOutOfRangeException(); }
        public int TuningPegs { get => tuningPegs; set => tuningPegs = value >= 0 && value <= MAX_TUNING_PEGS ? value : throw new ArgumentOutOfRangeException(); }

        public StringedInstrument(string instrumentType, string brand, string model, int yearManufactured, string color, int instrumentCount, int strings, int frets, int tuningPegs) : base(instrumentType, brand, model, yearManufactured, color, instrumentCount)
        {
            Strings = strings;
            Frets = frets;
            TuningPegs = tuningPegs;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Strings: {Strings}, Frets: {Frets}, TuningPegs: {TuningPegs}";
        }
    }
}
