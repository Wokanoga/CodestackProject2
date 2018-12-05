using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Fonts;
using System.IO;
namespace GameDemo
{
    public partial class MainForm : MetroForm
    {
        int i = 0;
        string readingFromFile = "";

        public string soundChoice = "Off";
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"TitleTheme.wav");
            player.PlayLooping();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waluigi.Left = waluigi.Left - 2;
            if (waluigi.Left < this.Left-waluigi.Width*2)
            {
                waluigi.Left = this.Width;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
