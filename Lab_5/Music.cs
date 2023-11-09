using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Music
    {
        private MusicalInstrument[] music;
        public MusicalInstrument[] Music_ { get { return music; } }
        public Music()
        {
            music = Array.Empty<MusicalInstrument>();
        }
        public Music(params MusicalInstrument[] _music)
        {
            music = _music;
        }
        public void AddInstrument(MusicalInstrument musicInstrument)
        {
            Array.Resize(ref music, music.Length + 1);
            music[^1] = musicInstrument;
        }
     
        public void RemoveInstrument(int index)
        {
            if (index < 0 || index >= music.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            music = music.Take(index).Concat(music.Skip(index + 1)).ToArray();
        }

        public void EditInstrument(int index, MusicalInstrument newMusicalInstrument)
        {
            if (index < 0 || index >= music.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            music = music.Select((instrument, i) => i == index ? newMusicalInstrument : instrument).ToArray();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var musicInstrument in music)
            {
                result.AppendLine(musicInstrument.ToString());
            }

            return result.ToString();
        }

    }
}
