﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaMojaDrugaAplikacija
{
    public partial class Form1 : Form
    {
        int br = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            br++;
            txtPrikaz.Text = br.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            br--;
            txtPrikaz.Text = br.ToString();
        }
    }
}
