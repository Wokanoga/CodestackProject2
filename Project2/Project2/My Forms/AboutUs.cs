﻿using System;
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
using System.Media;
namespace Project2.My_Forms
{
    public partial class AboutUs : MetroForm
    {
        public AboutUs()
        {
            InitializeComponent();
            lb_Info.Left = this.Width / 2 - lb_Info.Width / 2;
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
        }
    }
}
