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
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace Project2.My_Forms
{
    public partial class TitlePage : MetroForm
    {
        string musicChoice = "off";
        SoundPlayer player = new SoundPlayer(@"TitleTheme.wav");

        public TitlePage()
        {
            InitializeComponent();
            Image waluigi = new Bitmap(@"Pictures/WAAAHH.png");
            waluigi = resizeImage(waluigi, new Size(pic_Waluigi.Width, pic_Waluigi.Height));
            pic_Waluigi.BackgroundImage = waluigi;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void TitlePage_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer(@"Sounds/TitleTheme.wav");
            player.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic_Waluigi.Left = pic_Waluigi.Left - 2;
            if (pic_Waluigi.Left < this.Left - pic_Waluigi.Width * 2)
            {
                pic_Waluigi.Left = this.Width;
            }
        }

        public void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Music_Click(object sender, EventArgs e)
        {
            switch (musicChoice)
            {
                case ("off"):
                    musicChoice = "on";
                    player.Stop();
                    break;
                case ("on"):
                    musicChoice = "off";
                    player.PlayLooping();
                    break;
            }
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
        }

    }
}
