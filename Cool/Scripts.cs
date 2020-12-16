using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Cool
{


    public partial class Scripts : UserControl
    {
        WebClient wc = new WebClient();

        EasyExploits.Module api = new EasyExploits.Module();

        public Scripts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Walkspeed(object sender, KeyPressEventArgs e)
        {

            string value = textBox1.Text;
            if(value == "attach")
            {
                api.LaunchExploit();
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Return))
                {
                    api.ExecuteScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + value);


                }
            }
            
        }

        private void Jumppower(object sender, KeyPressEventArgs e)
        {
            string value = textBox2.Text;

            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                api.ExecuteScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + value);

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string Dex = wc.DownloadString("https://raw.githubusercontent.com/Chefkoch2K/3NIGMA/master/DexExplorer");
            api.ExecuteScript(Dex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fly = wc.DownloadString("https://project-phantom.000webhostapp.com/roflyscript.txt");
            api.ExecuteScript(fly);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string Dex = wc.DownloadString("https://raw.githubusercontent.com/Chefkoch2K/3NIGMA/master/DexExplorer");
            api.ExecuteScript(Dex);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string fly = wc.DownloadString("https://project-phantom.000webhostapp.com/roflyscript.txt");
            api.ExecuteScript(fly);
        }
    }
}
