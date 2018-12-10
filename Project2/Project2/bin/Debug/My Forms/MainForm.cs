using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace Project2
{
    public partial class MainForm : Form
    {
        Form title = new My_Forms.TitlePage();
        Form game = new My_Forms.ActualGame();

        public MainForm()
        {
            InitializeComponent();
            title.MdiParent = this;
            game.MdiParent = this;
            title.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (title.Visible == false)
            {
                game.Show();
            }
            if (title.Visible == false && game.Visible == false)
            {
                this.Close();
            }
        }
    }
}
