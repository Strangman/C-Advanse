﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagineFolder.Visible = true;
            try
            {
                pictureBoxMain.Image = Image.FromFile(imagineFolder.Text);
            }
            catch (ArgumentException)
            {
                imagineFolder.Text = "Enter image folder";
            }
            catch (Exception)
            {
                imagineFolder.Text = "Wrong image folder";
            }
        }
    }
}
