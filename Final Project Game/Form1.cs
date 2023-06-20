﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; 

            if (sender is Form)
            {
                f = (Form)sender;                          
            }
            else
            {
                UserControl current = (UserControl)sender;  
                f = current.FindForm();                     
                f.Controls.Remove(current);                 
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeScreen(this, new MenuScreen());
        }
    }
}
