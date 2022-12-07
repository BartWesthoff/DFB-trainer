using Memory;
using System;

namespace trainerzombie_game
{
    public partial class Form1 : Form
    {
        Mem meme = new Mem();
        string roundAddress = "GameAssembly.dll+0x00EA33C0,B8,60,50,80";
        string HealthAddressMap2 = "GameAssembly.dll+0x00F8F7C8,80,F20";
        string MysterboxPricesMap2 = "GameAssembly.dll+0x00F8F7C8,80,F20";
        string HealthAdressMap1 = "GameAssembly.dll+0x00F8F7C8,80,E60";
        string pointsMap2 = "GameAssembly.dll+0x00F9FBE8,290,750,AB0";

   




        string zombieCountAddress= "mono-2.0-bdwgc.dll+0x00740148,210,1c8,30,18";

        string ThrowablefunctionAdress = "GameAssembly.dll+0x247D9F";
        string HealthPackageFunctionAdress = "GameAssembly.dll+0x22B059"; // original GameAssembly.dll+22B059 - FF 4B 18             
        string AmmoFunctionAdress = "GameAssembly.dll+0x2606A5";
        string PointsFunctionAdress = "GameAssembly.dll+0x247F4F"; // original 01 7B 30

        string maxHealthMap2 = "GameAssembly.dll+0x00F9FBE8,80,F24";
       // string papweapon = "GameAssembly.dll" + 00F98960 ,8,3E4
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        
            if (godmodeBox.Checked) meme.WriteMemory(HealthAddressMap2, "int", "100000");
            if (pointsBox.Checked) meme.WriteMemory(pointsMap2, "int", (Int32.MaxValue -1).ToString()); 
      
        
        }

        private void setRoundButton_Click(object sender, EventArgs e)
        {
            meme.WriteMemory(roundAddress, "int",  roundUpDown.Value.ToString());
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
            }
        }    

        private void throwable_Click(object sender, EventArgs e)
        {
            meme.WriteMemory(ThrowablefunctionAdress, "bytes", "90 90 90");
        }

        private void AmmoButton_Click(object sender, EventArgs e)
        {
            meme.WriteMemory(AmmoFunctionAdress, "byte", "2");
        }

        private void freezePointsButton_Click(object sender, EventArgs e)
        {
            meme.WriteMemory(PointsFunctionAdress, "bytes", "90 90 90");
        }

        // write a function that triggers a function in memory




    }
}