using Memory;
using System;

namespace trainerzombie_game
{
    public partial class Form1 : Form
    {
        Mem meme = new Mem();
        string roundAddress = "GameAssembly.dll+0x00EA33C0,B8,60,50,80";
        string newHealthAddress = "GameAssembly.dll+0x00F2DAA8,280,E20";

        string pointsAddress = "GameAssembly.dll+0x00E85C30,B8,18,150";

        string secondAmmoAddress = "mono-2.0-bdwgc.dll+0x007160F8,78,610,140";

        string throwableAddress = "mono-2.0-bdwgc.dll+0x00740160,258,E88,40,160,D0,58,78";

        int currentRound =  1;
        int zombiesLeft =  -1;
        bool changeRound = false;

        string zombieCountAddress= "mono-2.0-bdwgc.dll+0x00740148,210,1c8,30,18";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        
            if (godmodeBox.Checked) meme.WriteMemory(newHealthAddress, "int", "9999999");
            if (pointsBox.Checked) meme.WriteMemory(pointsAddress, "int", (Int32.MaxValue -1).ToString()); 
            if (secondAmmoBox.Checked) meme.WriteMemory(secondAmmoAddress, "int", (Int32.MaxValue - 1).ToString());
            if (throwablesBox.Checked) meme.WriteMemory(throwableAddress, "int", (Int32.MaxValue - 1).ToString());
            zombiesLeft = meme.ReadInt(zombieCountAddress);
            label1.Text = zombiesLeft.ToString();
      
        
        }

        private void setRoundButton_Click(object sender, EventArgs e)
        {
            label1.Text = roundUpDown.Value.ToString();
            roundLabel.Text = currentRound.ToString();
            meme.WriteMemory(roundAddress, "int",  roundUpDown.Value.ToString());
        }

        private void endRoundButton_Click(object sender, EventArgs e)
        {
            meme.WriteMemory(roundAddress, "int", (Int32.MaxValue-1).ToString());


        }

        private void cButton_Click(object sender, EventArgs e)
        {
            int PID = meme.GetProcIdFromName("Dead From Beyond.exe");
            timer1.Stop();
            if (PID > 0)
            {
                System.Console.WriteLine("Started");
                meme.OpenProcess(PID);
                timer1.Start();
                label1.Text = "active";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentRound = meme.ReadInt(roundAddress);
            roundLabel.Text = currentRound.ToString();
            meme.WriteMemory(roundAddress, "int", "1");
            
        }

        private void roundUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}