using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class PercussionInstrument : MusicalInstrument
    {
        public static readonly int MAX_DRUMS = 5;
        public static readonly int MAX_CYMBALS = 3;
        public static readonly int MAX_STICKS = 10;

        private int drums;
        private int cymbals;
        private int sticks;

        public int Drums { get => drums; set => drums = value >= 0 && value <= MAX_DRUMS ? value : throw new ArgumentOutOfRangeException(); }
        public int Cymbals { get => cymbals; set => cymbals = value >= 0 && value <= MAX_CYMBALS ? value : throw new ArgumentOutOfRangeException(); }
        public int Sticks { get => sticks; set => sticks = value >= 0 && value <= MAX_STICKS ? value : throw new ArgumentOutOfRangeException(); }

        public PercussionInstrument(string instrumentType, string brand, string model, int yearManufactured, string color, int instrumentCount, int drums, int cymbals, int sticks) : base(instrumentType, brand, model, yearManufactured, color, instrumentCount)
        {
            Drums = drums;
            Cymbals = cymbals;
            Sticks = sticks;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Drums: {Drums}, Cymbals: {Cymbals}, Sticks: {Sticks}";
        }
    }
}
