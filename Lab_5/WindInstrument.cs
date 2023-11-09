using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class WindInstrument : MusicalInstrument
    {
        public static readonly int MAX_KEYS = 20;
        public static readonly int MAX_VALVES = 5;
        public static readonly int MAX_HOLES = 10;

        private int keys;
        private int valves;
        private int holes;

        public int Keys { get => keys; set => keys = value >= 0 && value <= MAX_KEYS ? value : throw new ArgumentOutOfRangeException(); }
        public int Valves { get => valves; set => valves = value >= 0 && value <= MAX_VALVES ? value : throw new ArgumentOutOfRangeException(); }
        public int Holes { get => holes; set => holes = value >= 0 && value <= MAX_HOLES ? value : throw new ArgumentOutOfRangeException(); }

        public WindInstrument(string instrumentType, string brand, string model, int yearManufactured, string color, int instrumentCount, int keys, int valves, int holes) : base(instrumentType, brand, model, yearManufactured, color, instrumentCount)
        {
            Keys = keys;
            Valves = valves;
            Holes = holes;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Keys: {Keys}, Valves: {Valves}, Holes: {Holes}";
        }
    }
}
