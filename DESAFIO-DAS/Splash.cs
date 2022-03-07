﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAFIO_DAS
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            progressBar1.Increment(4);
            Opacity -= 0.015;
            label1.Text =progressBar1.Value.ToString()+"%";

            if (Opacity==0.0)
            {
                timer1.Stop();
                this.Hide();
                Login login=new Login();
                login.ShowDialog();
            }
        }
    }
}
