using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    internal class Slang : Dier
    {
      
        




       public SoundPlayer SnakesoundPlayer;
       
        
        
        public Slang(int gewicht) : base(gewicht)
        {
        }

        public string ssst()
        {
            SnakesoundPlayer = new SoundPlayer("C:\\Users\\PC\\source\\repos\\DotNetAdvanced_Opdracht2\\Oef1\\bin\\Debug\\net6.0-windows\\slanggeluid.wav");
          
            return base.Zegt("ssj");
        }

        public override string? ToString()
        {
            return ssst();
        }
    }
}
