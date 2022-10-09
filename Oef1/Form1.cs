using System.Media;

namespace Oef1
{
    public partial class Form1 : Form
    {

        public SoundPlayer CowsoundPlayer;
        public SoundPlayer SnakesoundPlayer;
        public SoundPlayer PigSoundPlayer;
        public Form1()
        {
            InitializeComponent();
            CowsoundPlayer = new SoundPlayer("C:\\Users\\PC\\source\\repos\\DotNetAdvanced_Opdracht2\\Oef1\\bin\\Debug\\net6.0-windows\\koegeluid.wav");
            SnakesoundPlayer = new SoundPlayer("C:\\Users\\PC\\source\\repos\\DotNetAdvanced_Opdracht2\\Oef1\\bin\\Debug\\net6.0-windows\\slanggeluid.wav");
            PigSoundPlayer = new SoundPlayer("C:\\Users\\PC\\source\\repos\\DotNetAdvanced_Opdracht2\\Oef1\\bin\\Debug\\net6.0-windows\\varkengeluid.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dier koe = new Koe(800);
            Dier varken = new Varken(400);
            Dier slang = new Slang(3);

           
            if (checkBox1.Checked)
            {
                MessageBox.Show(koe.ToString());
                CowsoundPlayer.Play();

                
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show(slang.ToString());
                SnakesoundPlayer.Play();

                
               
            }

            if (checkBox3.Checked)
            {
                MessageBox.Show(varken.ToString());
                PigSoundPlayer.Play();
                
            }


            else {

                MessageBox.Show("Choose one of the animals ");

            }
        }

     }
    }

