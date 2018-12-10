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
namespace Project2.My_Forms
{
    public partial class DeathScreen : Form
    {
        public DeathScreen()
        {
            InitializeComponent();
        }

        private void DeathScreen_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"Sounds/DeathTheme.wav");
            player.PlayLooping();

            pic_Death.Left = Width / 2 - pic_Death.Width / 2;
            btn_Exit.Left = pic_Death.Left;
            btn_Restart.Left = pic_Death.Width - btn_Restart.Width/2;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
