using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    internal class Varken : Dier
    {
        
        
        
        
        
        public SoundPlayer PigsoundPlayer;
        public Varken(int gewicht) : base(gewicht)
        {
        }
        public string Oeink()
        {
            PigsoundPlayer = new SoundPlayer("C:\\Users\\PC\\source\\repos\\DotNetAdvanced_Opdracht2\\Oef1\\bin\\Debug\\net6.0-windows\\varkengeluid.wav");
            PigsoundPlayer.Play();
            return base.Zegt("groink");
        }

        public override string? ToString()
        {
            return Oeink();
        }
    }
}

