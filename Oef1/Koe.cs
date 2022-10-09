using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    internal class Koe : Dier
    {
        public SoundPlayer CowsoundPlayer;

        
        
        
        
        
        public Koe(int gewicht) : base(gewicht)
        {
        }

        public string boet()
        {
            CowsoundPlayer = new SoundPlayer("C:\\Users\\PC\\source\\repos\\DotNetAdvanced_Opdracht2\\Oef1\\bin\\Debug\\net6.0-windows\\koegeluid.wav");
            CowsoundPlayer.Play();
            return base.Zegt("boet");
        }

        public override string? ToString()
        {
            return boet();
        }


    }
}
